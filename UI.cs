//Form 1(movie page):
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dbms_final_proj
{
    public partial class Form1 : Form
    {
        Form2 form2;
        Form3 form3;
        Form4 form4;
        Form5 from5;
 
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            form3 = new Form3();
            form4 = new Form4();
            from5 = new Form5();
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'final_project_dbmsDataSet.movie_type' table. You can move, or remove it, as needed.


        }

        private void button1_Click(object sender, EventArgs e)
        {

            form2.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form3.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionstring= "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into movie_type values (@mv_id,@mv_name,@mv_language,@mv_rating,@mv_genre)", con);
            cmd.Parameters.AddWithValue("@mv_id", int.Parse(idBox1.Text));
            cmd.Parameters.AddWithValue("@mv_name", nameBox4.Text);
            cmd.Parameters.AddWithValue("@mv_language", lanBox3.Text);
            cmd.Parameters.AddWithValue("@mv_rating", decimal.Parse(ratingBox2.Text));
            cmd.Parameters.AddWithValue("@mv_genre", genreBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("inserted successfully!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("update movie_type set mv_name=@mv_name ,mv_language=@mv_language, mv_rating=@mv_rating, mv_genre= @mv_genre where mv_id=@mv_id", con);
            cmd.Parameters.AddWithValue("@mv_id", int.Parse(idBox1.Text));
            cmd.Parameters.AddWithValue("@mv_name", nameBox4.Text);
            cmd.Parameters.AddWithValue("@mv_language", lanBox3.Text);
            cmd.Parameters.AddWithValue("@mv_rating", decimal.Parse(ratingBox2.Text));
            cmd.Parameters.AddWithValue("@mv_genre", genreBox5.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("updated successfully!");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete movie_type where mv_id=@mv_id", con);
            cmd.Parameters.AddWithValue("@mv_id", int.Parse(idBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("deleted successfully!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from movie_type where mv_id=@mv_id", con);
            cmd.Parameters.AddWithValue("@mv_id", int.Parse(idBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();


        }

        private void button10_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from movie_type", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select  actors.actor_name from actor_cast_movies INNER JOIN actors  ON actor_cast_movies.actor_id=actors.actor_id where mv_id=(Select mv_id from movie_type where mv_name=@mv_name)", con);
            cmd.Parameters.AddWithValue("@mv_name", castBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select  directors.director_name from director_cast_movies INNER JOIN directors  ON director_cast_movies.director_id=directors.director_id where mv_id=(Select mv_id from movie_type where mv_name=@mv_name)", con);
            cmd.Parameters.AddWithValue("@mv_name", castBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            from5.ShowDialog();
        }
    }
}

//Form 2(TV shows page)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dbms_final_proj
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tvshow values (@tvs_tvsid,@tvs_name,@tvs_language,@tvs_rating,@tvs_genre,@tvs_parts)", con);
            cmd.Parameters.AddWithValue("@tvs_tvsid", int.Parse(idBox1.Text));
            cmd.Parameters.AddWithValue("@tvs_name", nameBox4.Text);
            cmd.Parameters.AddWithValue("@tvs_language", languageBox3.Text);
            cmd.Parameters.AddWithValue("@tvs_rating", decimal.Parse(ratingBox2.Text));
            cmd.Parameters.AddWithValue("@tvs_genre", genreBox5.Text);
            cmd.Parameters.AddWithValue("@tvs_parts", int.Parse(partsBox6.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("inserted successfully!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("update tvshow set  tvs_name=@tvs_name ,tvs_language=@tvs_language, tvs_rating=@tvs_rating, tvs_genre= @tvs_genre,tvs_parts=@tvs_parts where tvs_tvsid=@tvs_tvsid", con);
            cmd.Parameters.AddWithValue("@tvs_tvsid", int.Parse(idBox1.Text));
            cmd.Parameters.AddWithValue("@tvs_name", nameBox4.Text);
            cmd.Parameters.AddWithValue("@tvs_language", languageBox3.Text);
            cmd.Parameters.AddWithValue("@tvs_rating", decimal.Parse(ratingBox2.Text));
            cmd.Parameters.AddWithValue("@tvs_genre", genreBox5.Text);
            cmd.Parameters.AddWithValue("@tvs_[arts", int.Parse(partsBox6.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("updated successfully!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete tvshow where tvs_tvsid=@tvs_tvsid", con);
            cmd.Parameters.AddWithValue("@tvs_tvsid", int.Parse(idBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("deleted successfully!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from tvshow where tvs_tvsid=@tvs_tvsid", con);
            cmd.Parameters.AddWithValue("@tvs_tvsid", int.Parse(idBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from tvshow", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select  actors.actor_name from actor_cast_tvshow INNER JOIN actors  ON actor_cast_tvshow.actor_id=actors.actor_id where tvs_id=(Select tvs_tvsid from tvshow where tvs_name=@tvs_name)", con);
            cmd.Parameters.AddWithValue("@tvs_name", castBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select  directors.director_name from director_cast_tvshow INNER JOIN directors  ON director_cast_tvshow.director_id=directors.director_id where tvs_id=(Select tvs_tvsid from tvshow where tvs_name=@tvs_name)", con);
            cmd.Parameters.AddWithValue("@tvs_name", castBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

//Form 3 (documentaries page)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dbms_final_proj
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into documentries values (@doc_id,@doc_name,@doc_language,@doc_rating,@doc_genre,@doc_length)", con);
            cmd.Parameters.AddWithValue("@doc_id", int.Parse(idBox1.Text));
            cmd.Parameters.AddWithValue("@doc_name", nameBox4.Text);
            cmd.Parameters.AddWithValue("@doc_language", languageBox3.Text);
            cmd.Parameters.AddWithValue("@doc_rating", decimal.Parse(ratingBox2.Text));
            cmd.Parameters.AddWithValue("@doc_genre", genreBox5.Text);
            cmd.Parameters.AddWithValue("@doc_length",lengthBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("inserted successfully!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("update documentries set  doc_name=@doc_name ,doc_language=@doc_language, doc_rating=@doc_rating, doc_genre= @doc_genre,doc_length=@doc_length where doc_id=@doc_id", con);
            cmd.Parameters.AddWithValue("@doc_id", int.Parse(idBox1.Text));
            cmd.Parameters.AddWithValue("@doc_name", nameBox4.Text);
            cmd.Parameters.AddWithValue("@doc_language", languageBox3.Text);
            cmd.Parameters.AddWithValue("@doc_rating", decimal.Parse(ratingBox2.Text));
            cmd.Parameters.AddWithValue("@doc_genre", genreBox5.Text);
            cmd.Parameters.AddWithValue("@doc_length",lengthBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("updated successfully!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete documentries where doc_id=@doc_id", con);
            cmd.Parameters.AddWithValue("@doc_id", int.Parse(idBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("deleted successfully!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from documentries where doc_id=@doc_id", con);
            cmd.Parameters.AddWithValue("@doc_id", int.Parse(idBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from documentries", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select  actors.actor_name from actor_cast_documentries INNER JOIN actors  ON actor_cast_documentries.actor_id=actors.actor_id where doc_id=(Select doc_id from documentries where doc_name=@doc_name)", con);
            cmd.Parameters.AddWithValue("@doc_name", castBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select  directors.director_name from director_cast_documentries INNER JOIN directors  ON director_cast_documentries.director_id=directors.director_id where doc_id=(Select doc_id from documentries where doc_name=@doc_name)", con);
            cmd.Parameters.AddWithValue("@doc_name", castBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

//Form 4(web series page)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dbms_final_proj
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into webseries values (@wb_id,@wb_name,@wb_language,@wb_rating,@wb_genre,@wb_seasons)", con);
            cmd.Parameters.AddWithValue("@wb_id", int.Parse(idBox1.Text));
            cmd.Parameters.AddWithValue("@wb_name", nameBox4.Text);
            cmd.Parameters.AddWithValue("@wb_language", languageBox3.Text);
            cmd.Parameters.AddWithValue("@wb_rating", decimal.Parse(ratingBox2.Text));
            cmd.Parameters.AddWithValue("@wb_genre", genreBox5.Text);
            cmd.Parameters.AddWithValue("@wb_seasons", seasonsBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("inserted successfully!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("update webseries set  wb_name=@wb_name ,wb_language=@wb_language, wb_rating=@wb_rating, wb_genre= @wb_genre,wb_seasons=@wb_seasons where wb_id=@wb_id", con);
            cmd.Parameters.AddWithValue("@wb_id", int.Parse(idBox1.Text));
            cmd.Parameters.AddWithValue("@wb_name", nameBox4.Text);
            cmd.Parameters.AddWithValue("@wb_language", languageBox3.Text);
            cmd.Parameters.AddWithValue("@wb_rating", decimal.Parse(ratingBox2.Text));
            cmd.Parameters.AddWithValue("@wb_genre", genreBox5.Text);
            cmd.Parameters.AddWithValue("@wb_seasons", seasonsBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("updated successfully!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete webseries where wb_id=@wb_id", con);
            cmd.Parameters.AddWithValue("@wb_id", int.Parse(idBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("deleted successfully!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from webseries where wb_id=@wb_id", con);
            cmd.Parameters.AddWithValue("@wb_id", int.Parse(idBox1.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select *from webseries", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select  actors.actor_name from actor_cast_webseries INNER JOIN actors  ON actor_cast_webseries.actor_id=actors.actor_id where wb_id=(Select wb_id from webseries where wb_name=@wb_name)", con);
            cmd.Parameters.AddWithValue("@wb_name", castBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select  directors.director_name from director_cast_webseries INNER JOIN directors  ON director_cast_webseries.director_id=directors.director_id where wb_id=(Select wb_id from webseries where wb_name=@wb_name)", con);
            cmd.Parameters.AddWithValue("wb_name", castBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

//Form 4(Top page)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace dbms_final_proj
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("select top(3) *from movie_type order by mv_rating desc", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("select top(3) * from tvshow order by tvs_rating desc", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("select top(3) *from webseries order by wb_rating desc", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=DESKTOP-M4MPGOD\\SQLEXPRESS;Initial Catalog=final_project_dbms;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand("select top(3) *from documentries order by doc_rating desc", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}








