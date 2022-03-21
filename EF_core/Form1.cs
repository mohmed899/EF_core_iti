using EF_core.model;
namespace EF_core
{
    public partial class Form1 : Form
    {
        BlogContext db;
        public Form1()
        {
            InitializeComponent();
            db = new BlogContext();
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dvg_context.DataSource = db.Posts.Select(x => new { x.Id, x.Title, x.Body, x.Created, x.Post_Time ,x.auther.Name }).ToList();
            dvg_context.Columns[0].Visible = false;
            combo_author.DisplayMember = "Name";
            combo_author.ValueMember = "ID";
            combo_author.DataSource = db.Authers.ToList();

            combo_blog.DisplayMember = "Title";
            combo_blog.ValueMember = "ID";
            combo_blog.DataSource = db.Blogs.ToList();
            btn_add.Enabled = true;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int id = (int)dvg_context.SelectedRows[0].Cells[0].Value;
            Post p = db.Posts.Where(n => n.Id == id).SingleOrDefault();
            p.Title =  txt_posttitle.Text; 
            p.Body = txt_postbody.Text ;
            p.Post_Time= int.Parse( txt_posttime.Text) ;
            p.auther_id = (int)combo_author.SelectedValue;
            p.blog_id = (int)combo_blog.SelectedValue; 
           db.SaveChanges();
            Form1_Load(null, null);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Post post = new Post ()
            {
                Title = txt_posttitle.Text,
                Body = txt_postbody.Text,
                Created = DateTime.Now,
                Post_Time = int.Parse(txt_posttime.Text),
                 blog_id= (int)combo_blog.SelectedValue,
                auther_id = (int)combo_author.SelectedValue,

            };
            db.Posts.Add(post);
            db.SaveChanges();
            Form1_Load(null, null);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = (int)dvg_context.SelectedRows[0].Cells[0].Value;
            Post p = db.Posts.Where(n => n.Id == id).SingleOrDefault();
            db.Posts.Remove(p);
            db.SaveChanges();
            Form1_Load(null, null);
        }

        private void dvg_context_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            int id = (int)dvg_context.SelectedRows[0].Cells[0].Value;
            Post s = db.Posts.Where(n => n.Id == id).SingleOrDefault();
            txt_posttitle.Text = s.Title;
            txt_postbody.Text = s.Body;
            txt_posttime.Text = s.Post_Time.ToString();
            combo_author.SelectedValue = s.auther_id;
            combo_blog.SelectedValue = s.blog_id;
            btn_add.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}