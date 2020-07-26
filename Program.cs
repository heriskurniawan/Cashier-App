using System;

namespace cashier {
    class Program {
        static void Main (string[] args) {
            // Get Class Nama
            Nama dataNama = new Nama ();
            string namaBiskuit = dataNama.namabiskuit;
            string namaChips = dataNama.namachips;
            string namaOreo = dataNama.namaoreo;
            string namaTango = dataNama.namatango;
            string namaCokelat = dataNama.namacokelat;
            // Get Class harga
            Harga dataMakanan = new Harga ();
            uint Biskuit = dataMakanan.biskuit;
            uint Chips = dataMakanan.chips;
            uint Oreo = dataMakanan.oreo;
            uint Tango = dataMakanan.tango;
            uint Cokelat = dataMakanan.cokelat;
            // Get Class Stock
            Stock dataStock = new Stock ();
            int stockBiskuit = dataStock.stockbiskuit;
            int stockChips = dataStock.stockchips;
            int stockOreo = dataStock.stockoreo;
            int stockTango = dataStock.stocktango;
            int stockCokelat = dataStock.stockcokelat;

            Console.WriteLine ("=============================");
            Console.WriteLine ("       TOKO SEBELAH");
            Console.WriteLine ("Melayani pembelian makanan");
            Console.WriteLine ("=============================");
            Console.WriteLine ();
            transaksi:
                Console.WriteLine ("Menu pilihan :");
            Console.WriteLine ("1. " + namaBiskuit + "| " + Biskuit + "    | " + "Stock = " + stockBiskuit);
            Console.WriteLine ("2. " + namaChips + "  | " + Chips + "    | " + "Stock = " + stockChips);
            Console.WriteLine ("3. " + namaOreo + "   | " + Oreo + "   | " + "Stock = " + stockOreo);
            Console.WriteLine ("4. " + namaTango + "  | " + Tango + "   | " + "Stock = " + stockTango);
            Console.WriteLine ("5. " + namaCokelat + "| " + Cokelat + "   | " + "Stock = " + stockCokelat);
            string pilihan, ulang;
            byte quantity = 0;
            uint totalHarga, tunai, kembalian = 0;
            int[] pecahan = { 2000, 5000, 10000, 20000, 50000 };

            Console.WriteLine ();
            Console.Write ("Masukkan Angka Pilihan: ");
            uint pil = 0;
            string nama = "";
            int stock = 0;

            pilihan = Convert.ToString (Console.ReadLine ());
            if (pilihan == "1") {
                pil = Biskuit;
                nama = namaBiskuit;
                stock = stockBiskuit;

            } else if (pilihan == "2") {
                pil = Chips;
                nama = namaChips;
                stock = stockChips;

            } else if (pilihan == "3") {
                pil = Oreo;
                nama = namaOreo;
                stock = stockOreo;

            } else if (pilihan == "4") {
                pil = Tango;
                nama = namaTango;
                stock = stockTango;

            } else if (pilihan == "5") {
                pil = Cokelat;
                nama = namaCokelat;
                stock = stockCokelat;

            } else {
                Console.WriteLine ("Input yang anda masukan salah");

            }
            if (pilihan != "" && stock > 0) {
                Console.WriteLine ();
                Console.WriteLine (pilihan + "." + nama);
                Console.WriteLine ("—————————");

                // 2. input quantity
                Console.WriteLine ();
                Console.Write ("Masukkan Quantity: ");
                quantity = Convert.ToByte (Console.ReadLine ());

                // 3. Proses total harga
                totalHarga = pil * quantity;

                // 4. Output total harga
                Console.WriteLine ();
                Console.WriteLine ("# == == == == == == == == = # == == == == == == == #");
                Console.WriteLine ("Total Harga : Rp." + totalHarga.ToString ());

                // 5. Input tunai
                tunai:
                    Console.Write ("Tunai        : Rp");
                tunai = Convert.ToUInt32 (Console.ReadLine ());
                if (tunai == pecahan[0] || tunai == pecahan[1] || tunai == pecahan[3] || tunai == pecahan[4]) {
                    // 6. Proses kembalian
                    kembalian = tunai - totalHarga;

                    // 7. Output kembalian
                    Console.WriteLine ("Kembalian    : Rp." + kembalian.ToString ());
                    Console.WriteLine ("# == == == == == == == == = # == == == == == == == #");
                } else {
                    Console.Write ("Pecahan tidak sesuai..!");
                    Console.WriteLine ();
                    goto tunai;
                }
            } else {
                Console.Write ("Stock habis");
            }
            // Mengulang transaksi
            Console.WriteLine ();
            Console.Write ("Apakah anda ingin mengulang transaksi ? [y / t] : ");
            ulang = Convert.ToString (Console.ReadLine ());
            if (ulang == "y" || ulang == "Y")
                goto transaksi;
        }
    }
}