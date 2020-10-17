using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Musix.PackedPlugins.Packing;

namespace MusixPluginPacker
{
    public partial class Packer : Form
    {
        public Dictionary<string, string> Deps = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);

        public Packer()
        {
            InitializeComponent();
        }

        private void btnBrowseAsembly_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "Musix Plugin Files (.dll)|*.dll",
                Title = "Select Plugin"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtPluginAsm.Text = dialog.FileName;
            }
        }

        private void btnAddDep_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Filter = "DLL Files|*.dll|All Files|*.*",
                Multiselect = true,
                Title = "Add plugin dependencies"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string f in dialog.FileNames)
                {
                    FileInfo info = new FileInfo(f);

                    if (!Deps.ContainsKey(info.Name))
                    {
                        Deps.Add(info.Name, info.FullName);
                    }
                    listDep.Items.Add(info.Name);
                }
            }
        }

        private void btnRemDep_Click(object sender, EventArgs e)
        {
            if (listDep.SelectedItem != null)
            {
                string r = (string)listDep.SelectedItem;
                if (Deps.ContainsKey(r))
                {
                    Deps.Remove(r);
                }
                listDep.Items.RemoveAt(listDep.SelectedIndex);
            }
        }

        private void btnPack_Click(object sender, EventArgs e)
        {
            if (Version.TryParse(txtMinVersion.Text, out Version version))
            {
                PluginPackageBuilder builder = new PluginPackageBuilder()
                {
                    PluginTags = txtTags.Text.Split(' ').ToList(),
                    PluginDescription = txtDesc.Text,
                    AuthorName = txtAuthor.Text,
                    PluginName = txtName.Text,
                    WebsiteURL = txtWebsite.Text
                };
                if (txtIcon.Text.Length > 0 )
                {
                    string fl = txtIcon.Text.Replace("\"", "");
                    if (File.Exists(fl))
                    {
                        builder.PluginIcon = File.ReadAllBytes(fl);
                    }
                } 

                foreach(var ck in cblPlatforms.SelectedItems)
                {
                    builder.PlatformCompatability.TryAddPlatform(new Musix.PackedPlugins.Models.Platform(ck.ToString(), version));
                }

                builder.PluginAssembly = File.ReadAllBytes(txtPluginAsm.Text.Replace("\"", ""));
                foreach (var d in Deps)
                {
                    FileInfo info = new FileInfo(d.Value);
                    builder.Dependancies.Add(new Musix.PackedPlugins.Models.PackageBuilderDependancy()
                    {
                        AssemblyBytes = File.ReadAllBytes(d.Value),
                        FileName = info.Name,
                        FullName = info.Name
                    });
                }

                SaveFileDialog dialog = new SaveFileDialog()
                {
                    Filter = "Musix Plugin Files (*.MusixPlugin)|*.MusixPlugin",
                    DefaultExt = "MusixPlugin",
                    Title = "Pack Plugin"
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream writer = new FileStream(dialog.FileName, FileMode.CreateNew))
                    {
                        builder.Build(writer);
                    }
                    MessageBox.Show("Pack Complete!");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Invalid min version");
            }
        }

        private void Packer_Load(object sender, EventArgs e)
        {
        }

        private void btnBrowseIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "PNG Files|*.png",
                Title = "Select a plugin icon"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtIcon.Text = ofd.FileName;
            }
        }
    }
}