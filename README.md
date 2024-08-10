# CoreProject

**CoreProject** projesi, **ASP.NET Core MVC** ve **ASP.NET Core Web API** kullanılarak geliştirilmiş, katmanlı mimari (N-layer architecture) prensiplerine uygun bir web uygulamasıdır. Proje, SOLID prensiplerine uygun olarak tasarlanmış ve geliştirilmeye devam etmektedir.

## Kullanılan Teknolojiler

Bu projede kullanılan başlıca teknolojiler ve araçlar şunlardır:

- **ASP.NET Core MVC**: Web uygulamaları için kullanılan framework.
- **ASP.NET Core Web API**: RESTful servisler geliştirmek için kullanılan framework.
- **Entity Framework Core**: Veritabanı işlemleri için kullanılan ORM (Object-Relational Mapping) aracı.
- **SQL Server**: Veritabanı yönetim sistemi.
- **JavaScript**: Dinamik içerik ve kullanıcı etkileşimleri için kullanılan programlama dili.
- **Git**: Sürüm kontrol sistemi.
- **N-layer Architecture**: Uygulama mantığının katmanlar halinde organize edildiği mimari model.
- **View Component**: ASP.NET Core'da yeniden kullanılabilir bileşenler oluşturmak için kullanılan yapı.

## SOLID Prensipleri

Proje, yazılım geliştirme sürecinde yüksek kaliteyi ve esnekliği sağlamak amacıyla SOLID prensiplerine uygun olarak geliştirilmiştir:

- **S**ingle Responsibility Principle (SRP): Her sınıfın yalnızca bir sorumluluğu vardır.
- **O**pen/Closed Principle (OCP): Sınıflar, mevcut kodu değiştirmeden genişletilebilir olmalıdır.
- **L**iskov Substitution Principle (LSP): Türeyen sınıflar, temel sınıfların yerine kullanılabilir olmalıdır.
- **I**nterface Segregation Principle (ISP): Geniş arayüzler, daha küçük ve spesifik arayüzlere bölünmelidir.
- **D**ependency Inversion Principle (DIP): Üst seviye modüller, alt seviye modüllere bağımlı olmamalıdır; her ikisi de soyutlamalara bağımlı olmalıdır.

## Kurulum

Projeyi yerel ortamınıza kurmak için aşağıdaki adımları izleyin:

1. Reponuzu klonlayın: 
   ```bash
   git clone https://github.com/kadirn7/CoreProject.git
