# Fruit Appss
aplikasi ini berfungsi untuk menambahkan apa telah dipilih masuk ke dalam keranjang atau list box

# Fungsi
- tombol pilihan 
- list box view
- add item
- limit item

# Soal 
- Fungsi BucketEventListener adalah menampilak pop-up pesan
```csharp
    interface BucketEventListener
    {
        void onSucced(string message); // menampilkan pesan jika telah masuk input kedalam texbox
        void onFailed(string message); // menampilkan pop-up jika telah mencapai batas maksimum keranjang yg telah ditentukan
    }
```
- Mengapa saat di klik hanya 2 yang muncul tdak tidak bisa menambahkan ke keranjang
    karena listnya hanya di seting 2.
    berikut codingnya
```csharp
     {
            InitializeComponent();
            Bucket keranjang = new Bucket(2);
            BucketController bucketController = new BucketController(keranjang, this);

            nad = new Seller("Nad", bucketController);

            listBoxBucket.ItemsSource = keranjang.findAll();
        }
```