using FurnitureStore.Application.Views;
using System.ComponentModel;

namespace FurnitureStore.Forms
{
    public partial class FurnitureEditForm : Form, IFurnitureEditView
    {
        public event EventHandler? AcceptClicked;
        public event EventHandler? DenyClicked;

        public FurnitureEditForm()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FurnitureName
        {
            get => NameBox.Text;
            set => NameBox.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FurniturePrice
        {
            get => PriceBox.Text;
            set => PriceBox.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FurnitureDescription
        {
            get => DescBox.Text;
            set => DescBox.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool CanClose { get; set; }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            AcceptClicked?.Invoke(this, e);
            if (CanClose) Close();
        }

        private void DenyButton_Click(object sender, EventArgs e)
        {
            DenyClicked?.Invoke(this, e);
            if (CanClose) Close();
        }
    }
}
