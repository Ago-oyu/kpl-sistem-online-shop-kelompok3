using System;

public class OrderStatusManager
{
    private enum StatusPesanan
    {
        Baru,
        MenungguPembayaran,
        Diproses,
        Dikirim,
        Selesai,
        Dibatalkan
    }

    private StatusPesanan statusSaatIni;

    public OrderStatusManager()
    {
        statusSaatIni = StatusPesanan.Baru;
    }

    public void ProsesPembayaran()
    {
        if (statusSaatIni == StatusPesanan.Baru || statusSaatIni == StatusPesanan.MenungguPembayaran)
        {
            statusSaatIni = StatusPesanan.Diproses;
            Console.WriteLine("Pembayaran berhasil diproses. Pesanan sedang diproses.");
        }
        else
        {
            Console.WriteLine("Operasi tidak valid untuk status pesanan saat ini.");
        }
    }

    public void KirimPesanan()
    {
        if (statusSaatIni == StatusPesanan.Diproses)
        {
            statusSaatIni = StatusPesanan.Dikirim;
            Console.WriteLine("Pesanan telah dikirim.");
        }
        else
        {
            Console.WriteLine("Operasi tidak valid untuk status pesanan saat ini.");
        }
    }

    public void SelesaikanPesanan()
    {
        if (statusSaatIni == StatusPesanan.Dikirim)
        {
            statusSaatIni = StatusPesanan.Selesai;
            Console.WriteLine("Pesanan telah selesai.");
        }
        else
        {
            Console.WriteLine("Operasi tidak valid untuk status pesanan saat ini.");
        }
    }

    public void BatalkanPesanan()
    {
        if (statusSaatIni == StatusPesanan.Baru || statusSaatIni == StatusPesanan.MenungguPembayaran)
        {
            statusSaatIni = StatusPesanan.Dibatalkan;
            Console.WriteLine("Pesanan telah dibatalkan.");
        }
        else
        {
            Console.WriteLine("Operasi tidak valid untuk status pesanan saat ini.");
        }
    }

    public void TampilkanStatusPesanan()
    {
        Console.WriteLine($"Status Pesanan Saat Ini: {statusSaatIni}");
    }
}
