
using System.Text.RegularExpressions;
using System.Threading.Channels;
using TaskDrectorDataAccess.Contexts;
using TaskDrectorModel.Entitys;

DrectorDb drectorDb = new DrectorDb();

//2) rhyta.com ve ya dayrep.com domenlerinde emaili olan borclulari cixartmag
//


//var data = drectorDb.Debtors.ToList();
//List<Debtor> data2 = new List<Debtor>();
//for (int i = 0; i < data.Count; i++) { if (Regex.IsMatch(data[i].Email, @"[a-zA-Z0-9]+@rhyta.com")){ data2.Add(data[i]); } }
//foreach (var item in data2) { Console.WriteLine(item); }


//3) Yashi 26-dan 36-ya qeder olan borclulari cixartmag
//
//int year = (DateTime.Now.Year);
//var data = drectorDb.Debtors.Where(d=> year-d.BirthDay.Year> 26 && year - d.BirthDay.Year < 36).ToList();
//foreach (var item in data) { Console.WriteLine(item); }



//4) Borcu 5000-den cox olmayan borclularic cixartmag


//var data = drectorDb.Debtors.Where(d=>d.Debt<5000);
//foreach (var item in data) { Console.WriteLine(item); }

//5) Butov adi 18 simvoldan cox olan ve telefon nomresinde 2 ve ya 2-den cox 7 reqemi olan borclulari cixartmaq

//var data = drectorDb.Debtors.Where(d=>d.FullName.Length > 18 && d.Phone.Length > 1 && d.Debt.ToString().Length>7);

//foreach (var d in data) { Console.WriteLine(d); }


//7) Qishda anadan olan borclulari cixardmaq

//var data = drectorDb.Debtors.Where(d=>d.BirthDay.Month == 11 || d.BirthDay.Month == 1 || d.BirthDay.Month == 2).ToList();
//foreach (var item in data) { Console.WriteLine(item); }

//8) Borcu, umumi borclarin orta borcunnan cox olan borclulari cixarmaq ve evvel familyaya gore sonra ise meblegin azalmagina gore //sortirovka etmek

//var data = drectorDb.Debtors.ToList();
//int borclarinCemi = 0;
//foreach (var item in data) { borclarinCemi += item.Debt; }
//borclarinCemi /= data.Count;
//foreach (var item in data) { if(item.Debt < borclarinCemi) Console.WriteLine(item); }

//9) Telefon nomresinde 8 olmayan borclularin yalniz familyasin, yashin ve umumi borcun meblegin cixarmaq

//var data = drectorDb.Debtors.ToList();

//foreach (var item in data)
//{
//	bool yoxla = true;
//	foreach (var item2 in item.Phone)
//	{
//		if (item2 == '8') {  yoxla = false; break; }
//	}
//	if (yoxla) { Console.WriteLine(item); }

//}


//11)Adinda ve familyasinda hec olmasa 3 eyni herf olan borclularin siyahisin cixarmaq ve onlari elifba sirasina gore sortirovka //elemek
//bool yoxla(string str)
//{
//    var sonuc = str
//            .GroupBy(c => c)
//            .OrderByDescending(g => g.Count())
//            .First();
//    return sonuc.Count() > 2;
//}
//var data = drectorDb.Debtors.OrderBy(x => x.FullName).ToList();

//foreach (var item in data) { if(yoxla(item.FullName)) Console.WriteLine(item); }



//13)borclulardan en coxu hansi ilde dogulubsa hemin ili cixartmaq

//DateTime getDateTime(List<Debtor> debtors)
//{
//    var sonuc = debtors.GroupBy(d=>d.BirthDay.Year)
//        .OrderByDescending(deb => deb.Count())
//        .First();
//    return sonuc.First().BirthDay;
//}
//var data = drectorDb.Debtors.ToList();
//Console.WriteLine(getDateTime(data));

//14)Borcu en boyuk olan 5 borclunun siyahisini cixartmaq

//var data = drectorDb.Debtors.OrderByDescending(d=>d.Debt).Take(5).ToList();
//foreach (var item in data) { Console.WriteLine(item); }

//15)Butun borcu olanlarin borcunu cemleyib umumi borcu cixartmaq

//int cem = 0;
//var data = drectorDb.Debtors.Select(d=>d.Debt).ToList();
//foreach (var item in data) { cem += item; }
//Console.WriteLine(cem);

//16) 2 ci dunya muharibesin gormush borclularin siyahisi cixartmaq

//var data = drectorDb.Debtors.Where(d=>d.BirthDay.Year<1940).ToList();
//foreach (var item in data) { Console.WriteLine(item); }

//18)Nomresinde tekrar reqemler olmayan borclularin ve onlarin borcunun meblegin cixartmaq

//bool TekratTap(string str)
//{
//    var sonuc = str.Where(s=>s != '-').GroupBy(s => s)
//        .OrderByDescending(s => s.Count())
//        .First();

//    return sonuc.Count() > 1;
//}
//var data = drectorDb.Debtors.ToList();
//foreach (var item in data)
//{
//    if (TekratTap(item.Phone)) { Console.WriteLine(item); }

//}

//19)Tesevvur edek ki, butun borclari olanlar bugunden etibaren her ay 500 azn pul odeyecekler. Oz ad gunune kimi borcun oduyub //qurtara bilenlerin siyahisin cixartmaq

//var data = drectorDb.Debtors.Where(d=>d.Debt<=500).ToList();
//foreach (var d in data)
//{
//    d.Debt -= 500;
//    Console.WriteLine(d);
//}

//20)Adindaki ve familyasindaki herflerden "smile" sozunu yaza bileceyimiz borclularin siyahisini cixartmaq


bool SimvolTap(string str, char ch)
{
    var sonuc = str.Contains(ch);
    return sonuc;
}


var data = drectorDb.Debtors.ToList();
foreach (var d in data)
{
    if(SimvolTap(d.FullName, 's') && SimvolTap(d.FullName, 'm') && SimvolTap(d.FullName, 'i') && SimvolTap(d.FullName, 'l') && SimvolTap(d.FullName, 'e')) Console.WriteLine(d);
}