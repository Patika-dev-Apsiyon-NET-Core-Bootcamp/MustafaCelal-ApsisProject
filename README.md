# Apsis Apartman Yönetim Sistemi

***Katmanlar :***

## Core

Bu katmanda Entitylerimiz ve bu verilerin repositoryLerinin interface hali bulunuyor.<br>
Entitylerimiz veritabanındaki tablolarımıza denk gelmekte.<br>

Bu katmandaki interfacelerde entitylerimize hangi amaçlarla erişebileceğimizi bildiriyoruz.<br>
<br>
***RepositoryPattern*** kullanılarak Kod tekrarını azalttık ve yönetimini kolaylaştırdık.
<br>
IRepository'de diğer repository interfacelerinde ortak olan fonksiyon bildirimlerini yazdık böylelikle hem hız kazandık hem de tekrarın önüne geçtik.
<br>


## Data

Bu katmanda Veritabanına erişimimizi yönetiyoruz.<br>
*Core* katmanında yazdığımız repository interfacelerimizin burada somutlarını yazıyoruz.<br>
Oluşturduğumuz ***AppDbContext*** ile core katmanındaki entitylerimizi veritabanındaki tablolara map ediyoruz.<br>

## Application
Bu katmanda verilerimizi tamamen uygulamanın kullanacağı hale getirmeye çalışıyoruz.<br>

**Interfaces** klasöründe uygulamamımızın kullanabileceği fonksiyonları belirtiyoruz.<br>
**Services** klasöründe ise bu interfacelerin somut hallerini yazıyoruz.
<br>
Bu katmanda verilere veri tabanındaki haliyle değil de kullanıcının ihtiyacına uygun bir şekilde erişmemeye çalışıyoruz bundan dolayı bu verilerin uygulamada kullanacağımız halini **ViewModel** klasöründe bulunduruyoruz.<br>
**Profiles** da bu Viewmodel'deki verileri ***AutoMapper*** aracılığı ile veritabanındaki haline mapliyoruz.<br>
**DependencyContainer** içerisinde sistemdeki bağımlılıkları yönetiyoruz. Biz verilere erişirken ***DependencyInjection*** yöntemini kullanıyoruz. Bağımlılıkları tek bir yerden yönetmek için ve uygulamayı kullanacağımız katmandaki startup içerisinde kod karmaşası olmaması için IServiceCollection interface'ine extension method yazarak burada erişiyoruz. Bu methodu daha sonra startup->configureServices içerisinde kullanıyoruz.<br>
Veritabanı bağlantı context'imizi de burada yönetiyoruz.

## API

Bu katmanda artık uygulamamızı çeşitli routingler ile dış dünyaya açıyoruz.<br>

## WebUI

Bu katmanda uygulamamızı bir web sayfası şeklinde sunuyoruz.





