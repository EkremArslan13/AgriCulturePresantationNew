# AgriCulture (.NET Core Web Project)

Murat Yücedağ eğitici müfredatı takip edilerek geliştirilmiş, modern tarım ve kurumsal yönetim odaklı bir web uygulaması projesidir.

## 🛠️ Kullanılan Teknolojiler & Araçlar
* **Backend:** ASP.NET Core
* **Veritabanı:** Entity Framework Core & MS SQL Server
* **Tasarım/Arayüz:** HTML5, CSS3, Bootstrap, JavaScript, Tema Entegrasyonları
* **Mimariler:** Katmanlı Mimari (N-Tier Architecture)

## 🏗️ Proje Mimarisi (N-Tier Architecture)
Proje, sürdürülebilir ve kurumsal standartlara uygun olması amacıyla 4 temel katman üzerine inşa edilmiştir:
1. **EntityLayer:** Projede kullanılacak veri modellerinin (Entities) ve tabloların tanımlandığı katman.
2. **DataAccessLayer:** Veritabanı bağlantılarının, Context sınıfının ve veri tabanı operasyonlarının (CRUD) yürütüldüğü katman.
3. **BusinessLayer:** İş kurallarının (Validation, loglama, şartlı durumlar) kontrol edildiği ve DataAccess ile UI arasında köprü olan katman.
4. **AgriCulturePresentation (UI):** Kullanıcının etkileşime girdiği, Controller ve View yapılarının yer aldığı, web arayüzünü barındıren ana katman.

## 🚀 Öne Çıkan Özellikler
* Tamamen dinamik, yönetim paneli (Admin Dashboard) üzerinden kontrol edilebilir içerik altyapısı.
* Katmanlı mimari kurallarına uygun, temiz ve okunabilir kod yapısı.
* SOLID prensiplerine dikkat edilerek geliştirilmiş backend mimarisi.
  
## 🔐 Güvenlik ve Kimlik Doğrulama (ASP.NET Core Identity)
Sistemdeki kullanıcı yönetimi ve oturum güvenliği **ASP.NET Core Identity** kütüphanesi entegre edilerek sağlanmıştır. Projede şu temel güvenlik yapıları pratik edilmiştir:
* **Kimlik Doğrulama (Authentication):** Kullanıcı kayıt (Register) ve giriş (Login) mekanizmalarının kurulması.
* **Şifre Güvenliği:** Kullanıcı şifrelerinin veri tabanında düz metin olarak değil, Identity'nin sunduğu güvenli şifreleme (Password Hashing) algoritmalarıyla kriptolanarak saklanması.
* **Oturum Yönetimi (Cookie Authentication):** Kullanıcıların sisteme giriş yaptıktan sonra güvenli bir şekilde çerezler (Cookies) üzerinden oturumlarının takibi ve çıkış (Logout) işlemlerinin yapılması.
