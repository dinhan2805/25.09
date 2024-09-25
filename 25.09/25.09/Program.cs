using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();

        // Goi cac phuong thuc bai tap
        program.BaiTap1();
        program.BaiTap2();
        program.BaiTap3();
    }

    // Bai tap 1: Su dung ArrayList
    public void BaiTap1()
    {
        ArrayList arrayList = new ArrayList();
        Console.WriteLine("Nhap cac so nguyen (nhap 'x' de dung):");
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "x") break;
            if (int.TryParse(input, out int number))
            {
                arrayList.Add(number);
            }
            else
            {
                Console.WriteLine("Vui long nhap mot so nguyen hop le.");
            }
        }

        arrayList.Sort();
        Console.WriteLine("Danh sach cac so nguyen da nhap theo thu tu tang dan:");
        foreach (int number in arrayList)
        {
            Console.WriteLine(number);
        }
    }

    // Bai tap 2: Su dung Hashtable
    public void BaiTap2()
    {
        Hashtable hashtable = new Hashtable();
        Console.WriteLine("Nhap ten va tuoi (nhap 'x' de dung):");
        while (true)
        {
            Console.Write("Ten: ");
            string name = Console.ReadLine();
            if (name.ToLower() == "x") break;

            Console.Write("Tuoi: ");
            string ageInput = Console.ReadLine();
            if (ageInput.ToLower() == "x") break;
            if (int.TryParse(ageInput, out int age))
            {
                hashtable[name] = age;
            }
            else
            {
                Console.WriteLine("Vui long nhap mot tuoi hop le.");
            }
        }

        Console.WriteLine("Danh sach ten va tuoi da nhap:");
        foreach (DictionaryEntry entry in hashtable)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }

    // Bai tap 3: Su dung Dictionary
    public void BaiTap3()
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
        Console.WriteLine("Nhap ten va diem cua hoc sinh (nhap 'x' de dung):");
        while (true)
        {
            Console.Write("Ten hoc sinh: ");
            string name = Console.ReadLine();
            if (name.ToLower() == "x") break;

            Console.Write("Diem: ");
            string scoreInput = Console.ReadLine();
            if (scoreInput.ToLower() == "x") break;
            if (int.TryParse(scoreInput, out int score))
            {
                dictionary[name] = score;
            }
            else
            {
                Console.WriteLine("Vui long nhap mot diem hop le.");
            }
        }

        Console.WriteLine("Danh sach hoc sinh va diem:");
        foreach (var entry in dictionary)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
}
