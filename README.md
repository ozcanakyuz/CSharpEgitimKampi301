## Veritabanı İstatistikleri ve Kod Açıklamaları

Bu projede, bir veritabanındaki **Location** ve **Guide** tabloları üzerinden çeşitli istatistiksel veriler elde etmeyi öğrendim. Aşağıda, her bir istatistiksel veriyi nasıl sorguladığımı ve gösterdiğimi açıklıyorum:

1. **Lokasyon Sayısı**  
   Konumların toplam sayısını bulmak için:
   ```csharp
   lblLocationCount.Text = db.Location.Count().ToString();
   ```

2. **Toplam Kapasite**  
   Tüm konumların kapasite toplamını hesaplamak için:
   ```csharp
   lblSumCapacity.Text = db.Location.Sum(x => x.Capacity).ToString();
   ```

3. **Rehber Sayısı**  
   Rehberlerin toplam sayısını bulmak için:
   ```csharp
   lblGuideCount.Text = db.Guide.Count().ToString();
   ```

4. **Ortalama Kapasite**  
   Konumların kapasitesinin ortalamasını hesaplamak için:
   ```csharp
   lblAvgCapacity.Text = $"{db.Location.Average(x => x.Capacity):F2}";
   ```

5. **Ortalama Tur Fiyatı**  
   Konumların fiyatlarının ortalamasını bulmak için:
   ```csharp
   lblAvgPrice.Text = $"{db.Location.Average(x => x.Price):F2} ₺";
   ```

6. **Eklenen Son Ülke**  
   En son eklenen ülkenin adını almak için:
   ```csharp
   int lblLastCountryId = db.Location.Max(x => x.LocationId);
   lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lblLastCountryId).Select(y => y.Country).FirstOrDefault();
   ```

7. **Kapadokya Tur Kapasitesi**  
   Kapadokya'daki ilk konumun kapasitesini almak için:
   ```csharp
   lblCappadociaLocationCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
   ```

8. **Türkiye Turları Ortalama Kapasite**  
   Türkiye'deki konumların kapasite ortalamasını hesaplamak için:
   ```csharp
   lblTurkiyeCapacityAvg.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();
   ```

9. **Roma Gezi Rehberi**  
   Roma Turistik şehrine ait rehberin adını ve soyadını almak için:
   ```csharp
   var romaGuideId = db.Location.Where(x => x.City == "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();
   lblRomaGuideName.Text = db.Guide.Where(x => x.GuideId == romaGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();
   ```

10. **En Yüksek Kapasiteli Tur**  
   En yüksek kapasiteye sahip konumu bulmak için:
   ```csharp
   var maxCapacity = db.Location.Max(x => x.Capacity);
   lblMaxCapacityLocation.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();
   ```

11. **En Pahalı Tur**  
   En pahalı konumu bulmak için:
   ```csharp
   var maxPriceLocation = db.Location.Max(x => x.Price);
   lblMaxPriceLocation.Text = db.Location.Where(x => x.Price == maxPriceLocation).Select(y => y.City).FirstOrDefault().ToString();
   ```

12. **Ayşegül Çınar Tur Sayısı**  
   Ayşegül Çınar rehberinin yönettiği tur sayısını bulmak için:
   ```csharp
   var guideIdByNameAysegulCinar = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
   lblAsyegulCinarLocationCount.Text = db.Location.Where(x => x.GuideId == guideIdByNameAysegulCinar).Count().ToString();
   ```

---

### Ekran Görüntüsü

Aşağıda, bu kodların çalıştığı formun ekran görüntüsünü bulabilirsiniz:

![Ekran görüntüsü 2024-11-24 202701](https://github.com/user-attachments/assets/19a697ac-f489-4dac-9903-715ce74a39bf)

---

Bu kodlar sayesinde, veritabanındaki farklı verileri sorgulayarak önemli istatistiklere kolayca erişebiliyorum.
