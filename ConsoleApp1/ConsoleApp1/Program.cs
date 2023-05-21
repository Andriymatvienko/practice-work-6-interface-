using System;

interface IParent
{
    string Info();
    void Metod1();
    void Metod2();
}

class Child1 : IParent
{
    private double pole1;
    private double pole2;

    public Child1(double salary)
    {
        pole1 = salary;
    }

    public string Info()
    {
        return $"На ставке: ЗП = {pole1}, Премия = {pole2}";
    }

    public void Metod1()
    {
        // Зарплата вже обчислена
    }

    public void Metod2()
    {
        pole2 = 0.25 * pole1;
    }
}

class Child2 : IParent
{
    private double pole1;
    private double pole2;
    private int pole3;
    private double pole4;

    public Child2(int hours, double hourRate)
    {
        pole3 = hours;
        pole4 = hourRate;
    }

    public string Info()
    {
        return $"Почасово: Зп = {pole1}, Премия = {pole2}, Количество часов = {pole3}, Цена за 1 час = {pole4}";
    }

    public void Metod1()
    {
        pole1 = pole3 * pole4;
    }

    public void Metod2()
    {
        pole2 = 2000;
    }
}

class Child3 : IParent
{
    private double pole1;
    private double pole2;
    private double pole5;

    public Child3(double salesAmount)
    {
        pole5 = salesAmount;
    }

    public string Info()
    {
        return $"На проценте: ЗП = {pole1}, Премия = {pole2}, Сумма продажи = {pole5}";
    }

    public void Metod1()
    {
        pole1 = 0.1 * pole5;
    }

    public void Metod2()
    {
        pole2 = 0.2 * pole1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            int employeeType = random.Next(3); // Випадково вибираємо тип співробітника

            if (employeeType == 0)
            {
                double salary = random.Next(1000, 5000); // Випадкова зарплата
                Child1 child1 = new Child1(salary);
                child1.Metod1();
                child1.Metod2();
                Console.WriteLine(child1.Info());
            }
            else if (employeeType == 1)
            {
                int hours = random.Next(80, 200); // Випадкова кількість годин
                double hourRate = random.Next(10, 50); // Випадкова вартість 1 години
                Child2 child2 = new Child2(hours, hourRate);
                child2.Metod1();
                child2.Metod2();
                Console.WriteLine(child2.Info());
            }
            else
            {
                double salesAmount = random.Next(10000, 50000); // Випадкова сума продажу
                Child3 child3 = new Child3(salesAmount);
                child3.Metod1();
                child3.Metod2();
                Console.WriteLine(child3.Info());
            }
        }
        Console.ReadKey();
    }

}
