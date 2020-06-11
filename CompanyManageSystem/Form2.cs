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
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
namespace CompanyManageSystem
{
    public partial class weihu : Form
    {
        public weihu()
        {
            InitializeComponent();
        }
         private string RunCmd(string mysqldumPath, string strCmd)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.WorkingDirectory = mysqldumPath;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            p.StandardInput.WriteLine(strCmd);
            p.StandardInput.WriteLine("exit");
            return p.StandardError.ReadToEnd();
        }

         private void textBox1_TextChanged(object sender, EventArgs e)
         {

         }

         private void button1_Click(object sender, EventArgs e)
         {
             if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
             {
                 textBox1.Text = folderBrowserDialog1.SelectedPath;
             }
         }

         private void button2_Click(object sender, EventArgs e)
         {
             string backupsql = string.Format("mysqldump --host={0} --default-character-set=utf8 --lock-tables  --routines --force --port=3306 --user={1} --password={2} --quick  ", "127.0.0.1", "root", "root");
             string mysqldump = "D:\\MySql\\mysql-8.0.18-winx64\\bin";
             //需要备份的数据库名称
             string strDB = "c#";
             //备份数据库的路径
             string strDBpath = @textBox1.Text + "\\";

             //判断备份的数据库路径是否存在
             if (!Directory.Exists(strDBpath))
             {
                 Directory.CreateDirectory(strDBpath);
             }

             //备份数据库
             if (!string.IsNullOrEmpty(strDB))
             {
                 string filePath = strDBpath + DateTime.Now.ToString("yyyyMMdd_HHmmss") + strDB + ".sql";
                 string cmd = backupsql + strDB + " >" + filePath;
                 string result = RunCmd(mysqldump, cmd);

                 MessageBox.Show("数据库备份成功！", "提示");
             }
         }
         private void button4_Click(object sender, EventArgs e)
         {
             OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //调用mysqldump备份mysql数据库的语句
                string backupsql = string.Format("mysql --host={0} --default-character-set=utf8  --port=3306 --user={1} --password={2} ", "127.0.0.1", "root", "root");
                //mysql的路径
                string mysqldump = "D:\\MySql\\mysql-8.0.18-winx64\\bin";
                //需要备份的数据库名称
                string strDB = "c#";
                string filePath = ofd.FileName;
                MessageBox.Show(filePath,"当前选择的路径1");
                string cmd = backupsql+ strDB + " < \"" + filePath + "\"";
                string result = RunCmd(mysqldump, cmd);
                MessageBox.Show("数据库恢复成功!", "MySQL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }

         private void groupBox3_Enter(object sender, EventArgs e)
         {

         }

         private void label3_Click(object sender, EventArgs e)
         {

         }

         private void button3_Click(object sender, EventArgs e)
         {
             string constr = "server=127.0.0.1;port=3306;database=c#;username=root;password=123456;Charset=utf8;";
             MySqlConnection conn = new MySqlConnection(constr);
             conn.Open();
             string sql = "DROP TABLE IF EXISTS employee,in_product,out_product,product,sale_product,unit";
             MySqlCommand cmd = new MySqlCommand(sql, conn);
             try
             {
                 cmd.ExecuteNonQuery();
                 conn.Close();
                 MessageBox.Show("骚年，赶紧跑吧，你惹事了！");
             }catch(Exception es){
                 MessageBox.Show(es.Message);
             }
         }

         private void button5_Click(object sender, EventArgs e)
         {
             MessageBox.Show("青岛科技大学是一所以工为主，理、工、文、经、管、医、法、艺、教等学科协调发展、特色鲜明的多科性大学。学校是国家“111计划”立项建设单位、山东省属重点建设的大学和山东省应用基础型人才培养特色名校，被教育部评估为“本科教学工作水平评估优秀高校”“全国毕业生就业典型经验高校”和“全国创新创业典型经验高校”，荣获“山东省第一届省级文明校园”荣誉称号，被社会赞誉为“中国橡胶工业的黄埔“学校前身是创建于1950年的沈阳轻工业高级职业学校，1956年迁至青岛。1958年经山东省人民政府批准组建为山东化工学院，开始了正式举办高等教育的历程。1984年经教育部批准更名为青岛化工学院，1998年由化学工业部划转到山东省；2001年青岛工艺美术学校并入，2002年3月经教育部批准更名为青岛科技大学。2002年8月崂山校区投入使用，2009年高密校区投入使用，2016年山东省化工研究院整建制并入，2019年中德国际合作区（中德校区）投入使用，学校事业发展不断谱写新篇章。当前，学校形成了青岛、高密、济南“三地五校区”的办学格局，校舍面积92万平方米，图书馆馆藏各类文献资料300万余册，固定资产总值29亿元。学校师资力量雄厚，现有教职工2700余人，其中院士2人、双聘院士11人，中科院“百人计划”人选3人，国家高层次人才特殊支持计划（万人计划）领军人才（教学名师）2人，长江学者1人，国家杰青3人，国家优青2人，国家有突出贡献的中青年专家4人，国家级教学名师奖获得者1人，国家“百千万人才工程”人选3人，全国优秀教师10人，享受国务院政府特殊津贴49人，“泰山学者优势特色学科团队领军人才”2人，“泰山学者”特聘专家（教授）、海外特聘专家和青年专家44人，省级教学名师12人，山东省学科带头人5人，山东省重点学科（实验室）“首席专家”4人，山东省高校十大优秀教师3人，山东省杰青8人，山东省有突出贡献中青年专家36人。学校学科、专业特色鲜明，现拥有5个博士学位授权一级学科，5个博士后科研流动站，22个硕士学位授权一级学科，15个硕士专业学位类别，设有76个本科专业。形成了以材料科学与工程、化学工程与技术、动力工程及工程热物理等为代表的多个优势特色学科群，其中化学、材料科学、工程学等3个学科进入全球ESI学科排名前1%，4个学科入选山东省重点建设的“一流学科”行列，数量和影响力居省属高校前茅。在全国第四轮学科评估中，学校有9个学科进入前70%，其中化学工程与技术为B+，为省属工科高校唯一。学校坚持以人才培养为根本，获得2项国家级教学成果奖；1个国家级人才培养模式创新实验区；5个国家级特色专业，1个国家级专业综合改革试点项目，12个教育部工程教育认证专业，4个国家级“卓越工程师教育培养计划”试点专业；2个国家级实验教学示范中心，1个国家级虚拟仿真实验教学中心；2个国家级教学团队；2门国家级精品资源共享课，1门国家级精品视频公开课，2门国家级精品在线开放立项课程，1门国家级双语教学示范课程；1个国家级工程实践教育中心，1个教育部大学生校外实践教育基地建设项目；1名国家级教学名师；191个国家级大学生创新创业训练计划项目；39项省级教学成果奖；1个省级人才培养模式创新实验区；5个省级高水平应用型立项建设专业（群），16个省级品牌、特色专业；3个省级实验教学示范中心；7个省级教学团队；43门省级精品课程；12名省级教学名师；顺利通过了教育部本科教学审核评估。学校坚持科研兴校，科技创新能力不断提升，先后获得15项国家技术发明奖、国家科技进步奖、杜邦科技创新奖，2011年以来科研经费连续8年过亿元，累计近20亿元。科技创新平台建设成绩显著，现有1个国家工程实验室，1个国家工程技术研究中心，1个国家重点实验室培育基地，3个教育部重点实验室、工程研究中心，1个科技部国际科技合作基地，1个国家级大学科技园，国家层面创新平台数达到8个，数量位居山东省属高校前列。拥有3个省级协同创新中心，45个省级重点学科、重点实验室、工程技术研究中心。学校始终坚持走政产学研融合之路，科研成果运用到实际生产中已产生了巨大的经济效益，通过科研成果转化或提供核心技术支撑而上市的公司已经达到了7家，分别是软控股份有限公司、万华化学集团股份有限公司、赛轮股份有限公司、青岛金王集团、青岛海力威新材料科技股份有限公司、青岛旭域土工材料股份有限公司、青岛高校信息产业股份有限公司。学校连续两次被评为“山东省产学研合作创新突出贡献高校”，“青科大模式”广受赞誉，并被国务院研究室《决策参考》、中央电视台《新闻联播》《焦点访谈》等以典型经验和做法进行深度报道。学校坚持开放办学，不断完善对外交流与合作机制，同22个国家和地区的113所国（境）外高校签订了友好合作协议，获得1个教育部批准的中外合作办学机构，7个中外合作办学项目，基本形成了涵盖理、工、艺等学科专业多层次中外合作办学格局。其中与德国帕德博恩大学合作成立的中德科技学院，纳入中德两国政府间合作项目，被誉为中外合作办学的成功范例。引进德国双元人才培养模式，全面启动中德双元工程学院（中德校区）建设。牵头共建泰中国际橡胶学院，是山东首个在境外设立的办学机构，迈出了学校境外办学第一步。学校第十次党代会绘就了“三步走”的宏伟蓝图，提出了建设“有精神、有文化、有责任、有活力、有特色”高水平大学的奋斗目标。当前，学校坚持以习近平新时代中国特色社会主义思想为指导，深入贯彻落实党的十九大精神，紧密围绕国家“一流大学、一流学科”目标要求，坚持“内涵发展、创新发展、开放发展、协调发展、特色发展”的路径选择，主动对接服务新旧动能转换，发扬“科大精神”、践行“橡胶品格”、贯彻“五有理念”，凝心聚力、强化担当、狠抓落实，向着建设“双一流”和“五有”高水平大学的奋斗目标坚实迈进！");
         }

         private void button6_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void weihu_Load(object sender, EventArgs e)
         {
             color.load();
         }

         private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
         {

         }

         private void button8_Click(object sender, EventArgs e)
         {

         }

         private void button7_Click(object sender, EventArgs e)
         {
             shezhi fm2 = new shezhi();
             fm2.Owner = this;
             fm2.Show();
         }

    }
}
