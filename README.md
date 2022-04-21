# HometasksCsAdoNet

Aşağıdakı tablelarınız olacaq:
Stadions
 - Id
 - Name
 - HourPrice
 - Capacity

Users
 - Id
 - FullName
 - Email

Reservations
 - Id
 - StadionId
 - UserId
 - StartDate
 - EndDate



Layihə run olduqda bizə aşağıdakı kimi bir menu pəncərəsi görsənir:
 1. Stadion əlavə et
 2. Stadionları göstər
 3. Verilmiş id-li stadionu göstər
 4. Verilmiş id-li stadionu sil
 5. İstifadəçi əlavə et
 6. İstifadəçiləri göstər
 7. Rezervasiyaları göstər
 8. Rezervasiya yarat
 9. Verilmiş id-li stadionun rezervasiyalarını göstər


Dərsdə ən son yazdığımız sturukturda yazırsınız (Model folderi, Data folderi) Əlavə olaraq Main hissəsini də ayrıca bir Services folderi yaradıb orada classlarla ifadə edə bilərsiniz
 Eyni stadionda rezervasiyalar üst-üstə düşməməlidir.
 Eyni adda başqa stadion yaradıla bilməz
 İnputdan dəyərləri götürərkən düzgün dəyərlər götürdüyünüzdən əmin olur.Misalcün decimal bir dəyər üçün götürdüyünüz dəyərin decimal olduğunu yoxlayıb sonra query-e elave edin. DB-da Name maxlength 25-dirsə input olaraq 25den uzun ad gələrsə xəta vesajı verib təkrar daxil etmısini istəyin və s.

Əlavə olaraq DataTable, DataSet classlarını araşdırın ADO.NET ilə istifadədə


Məcburi olan hissə Stadionla bağlı olan menu seçimləridir, digər hissələr məcburi deyil
