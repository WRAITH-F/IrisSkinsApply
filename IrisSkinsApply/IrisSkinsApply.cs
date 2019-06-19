using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IrisSkinsApply
{
    public partial class IrisSkinsApply : Form
    {
        List<string> Skins;     //皮肤路径列表
        String SkinsName;      //皮肤文件名
        public IrisSkinsApply()
        {
            InitializeComponent();
            this.skinEngine.SkinFile = "Skins/SteelBlue.ssk";       //皮肤初始化（只加载一个皮肤）
        }

        private void IrisSkinsApply_Load(object sender, EventArgs e)
        {
            //获取所有皮肤列表的路径
            Skins = Directory.GetFiles(System.Environment.CurrentDirectory + "\\Skins\\", "*.ssk").ToList();
            Skins.ForEach(x =>
            {
                SkinsName = Path.GetFileNameWithoutExtension(x);    //获取皮肤的文件名
                SkinsChangeSub.DropDownItems.Add(new ToolStripMenuItem(SkinsName));     //在皮肤菜单选项中添加子菜单
                SkinsChangeSub.DropDownItems[SkinsChangeSub.DropDownItems.Count - 1].Click += new EventHandler(change_skin_Click);     //给子菜单添加点击事件
            });
        }
        private void change_skin_Click(object sender, EventArgs e)
        {
            var _this = this;
            Skins.ForEach(x =>
            {
                SkinsName = Path.GetFileNameWithoutExtension(x);    //获取文件名
                if (SkinsName == ((System.Windows.Forms.ToolStripDropDownItem)sender).Text)
                {
                    _this.skinEngine.SkinFile = x;  //将路径应用到skinEngine实现换肤
                    ((ToolStripMenuItem)sender).Checked = true;     //将选中的ToolStripMenuItem设置为true    
                }
            });
        }
    }
}
