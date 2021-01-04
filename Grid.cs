using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Linq;
using RentleForm.Classes;

namespace RentleForm
{
    public partial class Grid : Form
    {
        List<object> entitiesObj;
        public Grid()
        {
            InitializeComponent();
        }

        public async void ShowDialog<T>(string uri)
        {
            List<T> entities = await Utils.Get<T>(uri);
            dgv.DataSource = entities;
            this.Show();
        }

        public async void ShowDialog(List<object> value)
        {
            Console.WriteLine("COUOU");
            dgv.DataSource = value;
            this.Show();
        }





        public Dictionary<string, object> convertSubKeys(Dictionary<string, object> dictionnary)
        {
            Dictionary<string, object> newDic = new Dictionary<string, object>(dictionnary);
            foreach (string key in dictionnary.Keys)
            {
                object value = dictionnary[key];
                bool isDate = value.GetType() == typeof(DateTime);
                if (value != null && value.GetType() != typeof(string) && !isDate)
                {
                    newDic[key] = Utils.ToDictionnary(value);
                }
            }

            return newDic;
        }

        private async void generateDoc(string documentID)
        {
            GenBody genBody = new GenBody();
            genBody.id = documentID;
            Dictionary<string, object> genBodyDic = Utils.ToDictionnary(genBody);
            string genBodyJSON = Utils.ToJson(genBodyDic);
            await Utils.Post("http://localhost:5000/api/leases/GenerateGuarantorDeposit", genBodyJSON);
        }
        private void onCellClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = e.RowIndex;
            int x = e.ColumnIndex;

            object value = dgv[x, y].Value;
            bool isDate = value.GetType() == typeof(DateTime);
            Type valueType = value.GetType();
            if (valueType != typeof(string) && !isDate)
            {
                Grid grid = new Grid();
                if (valueType == typeof(List<object>))
                {
                    grid.ShowDialog((List<object>)value);
                } else
                {
                    List<object> list = new List<object>();
                    list.Add(value);
                    grid.ShowDialog(list);
                } 
            } else
            {
                List<Document> documents = ((IEnumerable<Document>)dgv.DataSource).Cast<Document>().ToList();
                generateDoc(documents[y].ID);
            }
        }
    }
}
