namespace Exercise_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string top3 = "";
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach (string world in this.txtBox.Text.Split(" "))
            {
                if(!dic.ContainsKey(world))
                    dic[world] = 1;
                else
                    dic[world] += 1;
            }

            var dic_ord = dic.OrderByDescending(x => x.Value);
            int i = 1;
            foreach (var kvp in dic_ord)
            {
                if(i > 3)
                    break;
                top3 += $"{i} --> {kvp.Key}: {kvp.Value}\n";
                i++;
            }

            MessageBox.Show($"El top 3 de palabras ingresadas fue: \n {top3}", "Top 3", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}