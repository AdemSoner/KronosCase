# Kronos Energy

**Onion Architecture**
`GetOrders` ile `InsertOrder` endpoint'lerini içermektedir.


https://localhost:7132/api/Orders

## 🛠️ Kurulum

### 1. Depoyu Klonla

git clone https://github.com/AdemSoner/KronosCase.git  

cd KronosCase

### 2. Projeyi Çalıştır  
dotnet build  

dotnet run --project Presentation\Case.API 

### 3. Swagger Arayüzünü Aç
Projeyi çalıştırdıktan sonra aşağıdaki URL'den Swagger UI arayüzüne erişebilirsin:

[http://localhost:5138/swagger/index.html](http://localhost:5138/swagger/index.html)  

📦 API Endpointleri  

✅ GET /api/orders  

Tüm siparişleri listeler.

📨 POST /api/orders  

Yeni bir sipariş ekler.

Örnek Gövde
{
 "cargoCompany": "Yurtiçi",
"adress": "Trabzon",
      "products": [
        "Uçak",
        "Bisiklet"
      ]
}
