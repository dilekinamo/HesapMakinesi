Console.Title="Hesap Makinesi V-1.0";

secimMetodu();

void secimMetodu() { 
    Console.WriteLine("1. Toplama");
    Console.WriteLine("2. Cikarma");
    Console.WriteLine("3. Carpma");
    Console.WriteLine("4. Bölme");
    Console.WriteLine("5. Cikis");
    Console.WriteLine("Lütfen bir secim yapin:");

    byte secim = Convert.ToByte(Console.ReadLine());

    switch (secim)
    {
        case 1:
            toplama();
            break;
        case 2:
            cikarma();
            break;
        case 3:
            carpma();
            break;
        case 4:
            bolme();
            break;
        case 5:
            cikis();
            break;
        default:
            defaultMetodu();
            break;
    }
}



void toplama()
{
    int operant1, operant2;
    //Console.WriteLine("toplama metodu");
    Console.Write("1. Operanti girin:");
    operant1=Convert.ToInt32(Console.ReadLine());
    Console.Write("2. Operanti girin:");
    operant2 =Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Islem sonucu "+(operant1+operant2));
    tekrarMi();
}

void cikarma()
{
    //Console.WriteLine("cikarma metodu");
    int operant1, operant2;
    Console.Write("1. Operanti girin:");
    operant1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("2. Operanti girin:");
    operant2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Islem sonucu " + (operant1 - operant2));
    tekrarMi();
}

void carpma()
{
    //Console.WriteLine("carpma metodu");
    int operant1, operant2;
    Console.Write("1. Operanti girin:");
    operant1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("2. Operanti girin:");
    operant2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Islem sonucu " + (operant1 * operant2));
    tekrarMi();
}

void bolme()
{
    //Console.WriteLine("bolme metodu");
    double operant1, operant2;
    Console.Write("1. Operanti girin:");
    operant1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("2. Operanti girin:");
    operant2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Islem sonucu " + (operant1 / operant2));
    tekrarMi();
}

void cikis()
{
    Console.WriteLine();
    Console.WriteLine("Hesap makinemizi tercih ettiginiz icin tesekkür ederiz!");
}

void defaultMetodu()
{
    //Console.WriteLine("default metodu");
    Console.Clear();
    Console.WriteLine("Gecersiz sayi girdiniz, tekrar girin: 1-5:");
    secimMetodu();
}

void tekrarMi()
{
    Console.WriteLine();
    Console.Write("Yeni bir işlem yapmak ister misiniz? (e/h) ");
    string devam = Console.ReadLine();
    if (devam == "e")
    {
        Console.Clear();
        secimMetodu();
    }
    else if (devam == "h")
    {
        cikis();
    }
    else { }
}

//switch (haftaninGunu)
//{
//    case 1:
//    case 2:
//    case 3:
//    case 4:
//    case 5:
//        Console.WriteLine("Hafta içi");
//        break;
//    case 6:
//    case 7:
//        Console.WriteLine("Hafta sonu");
//        break;
//    default:
//        Console.WriteLine("Hatalı giriş");
//        break;
//}