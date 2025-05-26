# 🧮 Basit Hesap Makinesi - C# Konsol Uygulaması

Bu C# uygulaması, iki sayı üzerinde temel matematiksel işlemleri gerçekleştiren basit bir **konsol tabanlı hesap makinesi**dir. Kullanıcıdan iki sayı alınır ve ardından istenen işlem seçilerek sonuç ekrana yazdırılır.

---

## 🚀 Başlangıç

### Gereksinimler

- .NET SDK yüklü olmalıdır ([.NET İndir](https://dotnet.microsoft.com/download))
- C# destekli bir IDE (Visual Studio, Visual Studio Code, vs.) önerilir.

---

## ⚙️ Uygulama Nasıl Çalışır?

1. Uygulama başlatıldığında kullanıcıdan iki tam sayı alınır.
2. Kullanıcıdan hangi işlemi yapmak istediği sorulur:
   - **Toplama** için: `t`
   - **Çıkarma** için: `ç`
   - **Çarpma** için: `x`
   - **Bölme** için: `b`
3. Seçilen işleme göre sonuç hesaplanır ve ekrana yazdırılır.
4. Eğer bölme işleminde ikinci sayı sıfır ise, **sıfıra bölme hatası** gösterilir.
5. Geçersiz bir işlem girilirse kullanıcı bilgilendirilir.

---

## 🧠 Kodun Çalışma Prensibi

- `Console.ReadLine()` ile kullanıcıdan giriş alınır.
- `Convert.ToInt32()` ile alınan girişler sayıya çevrilir.
- `if/else` blokları ile hangi işlemin seçildiği kontrol edilir.
- `Console.WriteLine()` ile sonuç yazdırılır.

---

## 💡 Örnek Kullanım

