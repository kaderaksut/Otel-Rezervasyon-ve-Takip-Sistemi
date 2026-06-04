# 🏨 Otel Rezervasyon ve Kontrol Sistemi

Bu proje, **C# ve Windows Forms App (.NET Framework)** kullanılarak geliştirilmiş bir otel yönetim, personel giriş kontrolü ve rezervasyon takip masaüstü uygulamasıdır. Proje; dinamik ücret hesaplama algoritmaları, hata yönetimi ve kullanıcı arayüzü mantığı üzerine kurulmuştur.

---

## 🛠️ Kullanılan Teknolojiler ve Yapılar
* **Geliştirme Dili:** C# (C-Sharp)
* **Geliştirme Ortamı:** Visual Studio
* **Arayüz Teknolojisi:** Windows Forms Application
* **Programlama Yapıları:** `if-else` kontrol blokları, `MessageBox` uyarı mekanizmaları, Event Handler fonksiyonları, Nesne Yönelimli Programlama (OOP) mantığı.

---

## 💻 Uygulama Modülleri ve Form Tasarımları

### 1. Şifreli Personel Giriş Ekranı (Form3)
* **Güvenlik Kapısı:** Personelin sisteme güvenli bir şekilde giriş yapmasını sağlar. Giriş bilgileri kontrol edilerek doğru ise kullanıcıyı ana ekrana yönlendirir.
* **Hata Yönetimi:** Bilgilerin hatalı veya eksik girilmesi durumunda `MessageBox` ile kullanıcıya *“Ad, soyad veya şifre hatalı”* şeklinde net bir bilgi mesajı verilir.
* **Giriş Kayıtları (Log Sistemi):** Yapılan her giriş denemesi (başarılı ya da hatalı fark etmeksizin) işlem yapılan anın **tarih ve saat bilgisiyle** birlikte arayüzdeki `ListBox` nesnesi üzerine dinamik olarak yazdırılarak kayıt altına alınır.

### 2. Oda Durum Paneli ve Rezervasyon İşlemleri
Uygulamanın kalbini oluşturan, oteldeki konaklama detaylarının yönetildiği ve hesaplamaların yapıldığı modüldür.
* **Dinamik Ücret Hesaplama:** `if-else` yapıları kullanılarak arka planda çalışan bir algoritma barındırır. Kalınacak gün sayısı, seçilen oda tipi (Radio Button verileri) ve tercih edilen ekstralar (Checkbox verileri) anlık olarak kontrol edilir.
* **Hesaplama Mantığı:** Gün sayısı önce oda tipi ücretiyle çarpılır; ardından seçilen ekstralar (`checkbox` kontrolleri ile işaretli alanlar tespit edilerek) kalacak gün sayısıyla çarpılarak ödenecek toplam tutara yansıtılır.
* **Veri Listeleme ("EKLE" Butonu):** Kullanıcı "EKLE" butonuna tıkladığında, girilen veriler arka plandaki kodlar sayesinde hesaplanıp *Rezervasyonlar* grubunun içindeki `ListBox`'a **ad, tarih ve saat** detaylarıyla eklenir. Toplam tutar ise *Ödenecek Tutar* panelindeki etiket alanına anlık yazdırılır.
* **Ekran Temizleme ("TEMİZLE" Butonu):** Bu butona tıklandığında seçili tüm işlemler ekrandan silinir, TextBox içerikleri ve seçim alanları arka plandaki temizleme kodları sayesinde ilk (boş) haline sıfırlanır.

---

## 📂 Depo İçeriği
* `Form1.cs` / `Form2.cs` / `Form3.cs` - Formların arkasında çalışan C# algoritmaları ve iş mantığı.
* `otel.rezervasyon.kontrol.sistemi.docx` - Projenin detaylı analiz ve tasarım raporu dokümanı.
