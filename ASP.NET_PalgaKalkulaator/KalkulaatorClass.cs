using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_PalgaKalkulaator
{
public class KalkulaatorClass
{
    private double _Bruto;
    private bool _TaxFree;
    private bool _UnemploymentCompany;
    private bool _Unemployment;
    private bool _SecondPillar;
    public KalkulaatorClass(double Bruto, bool TaxFree, bool UnemploymentCompany, bool Unemployment, bool SecondPillar)
    {
        _Bruto = Bruto;
        _TaxFree = TaxFree;
        _UnemploymentCompany = UnemploymentCompany;
        _Unemployment = Unemployment;
        _SecondPillar = SecondPillar;
    }
    public double IncomeTaxO() // Tulumaks.
    {

        if (_Bruto <= 180 && _TaxFree)
            return 0;
        else
            return (_Bruto - UnemploymentTaxEmployeeO() - SecondPillarO() - (_TaxFree ? 180 : 0)) * 20 / 100;
    }

    public double UnemploymentTaxEmployeeO()
    {
        return _Unemployment ? _Bruto * 1.6 / 100 : 0;
    }

    public double NetSalaryO()
    {
        return _Bruto - (SecondPillarO() + UnemploymentTaxEmployeeO() + IncomeTaxO());
    }

    public double SecondPillarO()
    {
        return _SecondPillar ? _Bruto * 2 / 100 : 0;
    }

    public double GrossSalaryO()
    {
        return _Bruto;
    }

    public double SocialTaxO()
    {
        return _Bruto * 33 / 100;
    }

    public static double UnemploymentTaxEmployee(double bruto) // Töötuskindlustusmakse (töötaja 1.6%).
    {
        return bruto * 1.6 / 100;
    }

    public double TotalCostforEmployerO()
    {
        return _Bruto + SocialTaxO() + UnemploymentTaxEmployerO();
    }

    public double UnemploymentTaxEmployerO()
    {
        return _UnemploymentCompany ? _Bruto * 0.8 / 100 : 0;
    }

    public static double SecondPillar(double bruto) // Kogumispension (II sammas 2%).
    {
        return bruto * 2 / 100;
    }

    public double TaxOfficeO()
    {
        return SocialTaxO() + SecondPillarO() + UnemploymentTaxEmployeeO() + IncomeTaxO() + UnemploymentTaxEmployerO();
    }

    public static double IncomeTax(double bruto, bool incTaxFree = true) // Tulumaks.
    {
        if (bruto < 187)
            return 0;
        else
            return (bruto - UnemploymentTaxEmployee(bruto) - SecondPillar(bruto) - (incTaxFree ? 180 : 0)) * 20 / 100;
    }

    public static double NetSalary(double bruto) // Netopalk.
    {
        return bruto - (SecondPillar(bruto) + UnemploymentTaxEmployee(bruto) + IncomeTax(bruto));
    }

    public static double GrossSalary(double bruto) // Brutopalk.
    {
        return bruto;
    }

    public static double SocialTax(double bruto) // Sotsiaalmaks.
    {
        return bruto * 33 / 100;
    }

    public static double UnemploymentTaxEmployer(double bruto) // Töötuskindlustusmakse (tööandja 0.8%).
    {
        return bruto * 0.8 / 100;
    }

    public static double TotalCostforEmployer(double bruto) // Tööandja kulu kokku (palgafond).
    {
        return bruto + SocialTax(bruto) + UnemploymentTaxEmployer(bruto);
    }

    public static double TaxOffice(double bruto) // Maksuametile(kõik maksud).
    {
        return SocialTax(bruto) + SecondPillar(bruto) + UnemploymentTaxEmployee(bruto) + IncomeTax(bruto) + UnemploymentTaxEmployer(bruto);
    }
}
}