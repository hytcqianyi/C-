using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ITXY
{
    public partial class UcFriend : UserControl
    {
        // public Friend CurFriend { get; set; }
        private Friend curFriend;

        public Friend CurFriend
        {
            get { return curFriend; }
            set { curFriend = value; }
        }

        public UcFriend()
        {
            InitializeComponent();
        }

        private void UcFriend_Load(object sender, EventArgs e)
        {

        }
    }
}
