﻿namespace Accommodation.Application.UseCases.Hotels.Commands;

public class CreateHotelCommand : IRequest<int>
{
    public string Name { get; set; }
    public string Address { get; set; }
    [Phone]
    public string Phone { get; set; }
    [Email]
    public string Email { get; set; }
    public int Stars { get; set; }
    public IFormFile ImagePath { get; set; }
    public long StaffId { get; set; }
    public long RoomId { get; set; }
}
