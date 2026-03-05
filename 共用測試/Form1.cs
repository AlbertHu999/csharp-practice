namespace 共用測試
{

    public record Product
    {
        public required string Name { get; init; }
        public decimal Price { get; init; }
        public int Stock { get; init; }
    }
    public partial class Form1 : Form
    {
        private List<Product> products = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string productName = string.IsNullOrWhiteSpace(txtProductName.Text)?"未輸入": txtProductName.Text;
            decimal price = decimal.TryParse(txtPrice.Text,out decimal p)?p:0;
            int stock = int.TryParse(txtStock.Text, out int s) ? s : 0;
            
            var product = new Product
            {
                Name = productName,
                Price = price,
                Stock = stock
            };
            products.Add(product);
            listBox1.Items.Add(product);
        }
    }
}
