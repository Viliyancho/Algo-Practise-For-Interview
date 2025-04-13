using System.Security.Cryptography.X509Certificates;


Cinema cinema = new Cinema(5, 5);

cinema.ReserveSeat("Viliyan", 1, 3);

cinema.PrintSeats();

public class Seat
{
    public int SeatRow { get; set; }
    public int SeatNumber { get; set; }
    public string UserName { get; set; }
    public bool isOccupied { get; set; }
}

public class Cinema
{
    private List<Seat> seats;

    public Cinema(int rows, int numbersPerRow, List<Seat> initialSeats)
    {
        seats = initialSeats; //dependency injection
        for (int i = 1; i <= rows; i++)
        {
            for(int j = 1; j <= numbersPerRow; j++)
            {
                seats.Add(new Seat() { SeatRow = i, SeatNumber = j,
                    UserName = null, isOccupied = false});
            }
        }
    }

    public bool ReserveSeat(string username, int row, int number)
    {
        var seat = seats.FirstOrDefault(s => s.SeatRow == row &&
        s.SeatNumber == number && s.isOccupied == false);

        if (seat == null)
            return false;

        seat.isOccupied = true;
        seat.UserName = username;
        Console.WriteLine($"{username} reserved seat on Row {row} and Number {number}");
        return true;
    }

    public void PrintSeats()
    {
        foreach (var item in seats)
        {
            var status = item.isOccupied ? $"[X] - by {item.UserName}" : "[]";

            Console.WriteLine($"Row {item.SeatRow} Seat {item.SeatNumber} {status}");
        }
    }
}

