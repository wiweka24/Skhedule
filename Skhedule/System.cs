using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skhedule
{
    class System
    {
        //instance
        private int _id;

        private int ID
        {
            get { return _id; }
        }

        //Method
        private void addUser()
        {
            //membuat local database baru dan menyimpan username dan password user
        }
        private void verifyData()
        {
            //mengecek username dan password masukan user dengan data di database
        }
        public void giveRecommendation()
        {
            //program memberikan rekomendasi berdsarkan activity input-an user
        }
        public void saveActivity()
        {
            //Menyimpan data masukan user ke database
        }
        public void deleteActivity()
        {
            //menghapus activity masukan 
        }
        public void display()
        {
            //Mengambil data dari database untuk ditampilkan
        }
        public void manageUser()
        {
            //mengambil data dari database, membantu user jika akan mengedit jadwal
            //memanggil void save, delete, dan display
        }
    }
}
