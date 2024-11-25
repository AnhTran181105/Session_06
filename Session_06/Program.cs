internal class Session_06
{
    public static void Main()
    {
        Session_06_ex_09();

    }
    public static int[] tao_mang_ngau_nhien()
    {
        Random rnd = new Random();
        int n = rnd.Next(0, 100) + 1;
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = (int)rnd.Next(0, 100) + 1;
        }
        return a;
    }
    public static void Session_06_ex_01()
    {
        Console.Write("Nhap n:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        Console.WriteLine("Nhap mang n phan tu:");
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            a[i] = a[i] + 2;
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }

    }
    public static void Session_06_ex_02()
    {
        int[] a = tao_mang_ngau_nhien();
        int s = 0;
        for (int i = 0; i < a.Length; i++)
        {
            
            s = s + a[i];
        }
        double avr = s / a.Length;
        Console.WriteLine($"Trung binh cua Array la:{avr}");
    }
    public static void Session_06_ex_03()
    {
        Console.WriteLine("Nhap so can tim:");
        int find=int.Parse(Console.ReadLine());
        int[] a = tao_mang_ngau_nhien();
        for (int i = 0; i < a.Length; i++)
        {
            if(a[i]==find)
            {
                Console.WriteLine($"Array co chua:{find}");
                return;
            }
        }
        Console.WriteLine($"Array khong chua:{find}");
    }
    public static void Session_06_ex_04()
    {
        Console.Write("Nhap so can tim:");
        int find = int.Parse(Console.ReadLine());
        int[] a = tao_mang_ngau_nhien();
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == find)
            {
                Console.WriteLine($"Vi tri cua {find} la {i+1}");
                return;
            }
        }
        Console.WriteLine($"Array khong chua:{find}");
    }
    public static void Session_06_ex_timkiem_nhi_phan()
    {

        Console.Write("Nhap n:");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        Console.WriteLine("Nhap mang n phan tu:");
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }
        int min = 0;
        int max = n-1;
        Console.Write("Nhap so can tim:");
        int find=int.Parse(Console.ReadLine());
        if (find > a[max] || find < a[min]) Console.WriteLine($"{find} khong ton tai trong Array");
        while (min < max)
        {
            int mid = (min + max) / 2;
            if (((a[mid]) / 2) > find)
            {
                max = mid-1;
            }
            else if (((a[min] + a[max]) / 2) < find)
            {
                min = mid+1;
            }
            else { Console.WriteLine($"Vi tri cua {find}:{mid}"); return; }
        }
        Console.WriteLine("Khong co so do trong mang");
    }
    public static void Session_06_ex_05()
    {
        Console.Write("Nhap so can xoa:");
        int find = int.Parse(Console.ReadLine());
        int[] a = tao_mang_ngau_nhien();
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == find)
            {
                int b= a[i];
                int[] a_new = a.Where(b => a[i] != find).ToArray();
                Console.WriteLine($"Da xoa {find} o vi tri {i + 1}");
                return;
            }
        }
        Console.WriteLine($"Array khong chua:{find}");
    }
    public static void Session_06_ex_06()
    {
        int[] a = tao_mang_ngau_nhien();
        int min = a[0]; int max = a[1];
        int phu;
        if (min>max) {phu=min ;min = max;max = phu; }
        for (int i = 2;i<a.Length;i++)
        {
            
            if (a[i] < min) min = a[i];
            else if (a[i] > max) max = a[i];
        }
        Console.WriteLine($"So lon nhat:{max}");
        Console.WriteLine($"So nho nhat:{min}");
    }
    public static void Session_06_ex_07()
    {
        int[] a = tao_mang_ngau_nhien();
        int[] b= new int[a.Length];
        int j=0;
        for (int i = a.Length-1;i>=0;i--)
        {
            b[j]= a[i];
            Console.WriteLine(a[j] + " " + b[j]);
            j++;
        }
    }
    public static void Session_06_ex_08()
    {
        int[] a = tao_mang_ngau_nhien();
        bool [] b= new bool[a.Length];
        Console.Write("Cac gia tri bi lap:");
        for (int i=0;i<a.Length;i++)
        {
            if (b[i] == true) continue;
            bool lap=false;
            for (int j=i+1;j<a.Length;j++)
            {
                if (a[j] == a[i])
                {
                    b[j]= true;
                    lap=true;
                }
            }
            if (lap==true) { Console.Write(a[i] + ","); }
        }
    }
    public static void Session_06_ex_09()
    {
        int[] a = tao_mang_ngau_nhien();
        int d = 0;
        bool[] b = new bool[a.Length];
        int[] c = new int[a.Length];
        Console.Write("Truoc khi loai bo lap:");
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i]+",");
            if (b[i] == true) continue;
            c[d] = a[i];
            for (int j = i + 1; j < a.Length; j++)
            {
                if (a[j] == a[i])
                {
                    b[j] = true;
                }
            }
            d++;
        }
        Console.Write("Sau khi bo lap:");
        for (int i = 0;i<d;i++)
        {
            Console.Write(c[i]+",");
        }
    }
}