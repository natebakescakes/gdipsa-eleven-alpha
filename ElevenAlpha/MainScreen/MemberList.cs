using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevenAlpha
{
    public partial class MemberList : Form
    {
        public MembersTab mainform;
        public MemberList()
        {
            InitializeComponent();
            ElevenAlphaEntities context = new ElevenAlphaEntities();
            MemberListCR memList = new MemberListCR();
            memList.SetDataSource(context.Members);
            MemberListCRV.ReportSource = memList;
        }
    }
}
