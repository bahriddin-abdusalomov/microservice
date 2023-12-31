﻿global using Accommodation.Application.Abstractions;
global using Accommodation.Application.Atributes.Email;
global using Accommodation.Application.Services.Files;
global using Accommodation.Application.Services.Helpers;
global using Accommodation.Application.UseCases.Bookings.Commands;
global using Accommodation.Application.UseCases.Bookings.Queries;
global using Accommodation.Application.UseCases.Guests.Commands;
global using Accommodation.Application.UseCases.Guests.Queries;
global using Accommodation.Application.UseCases.Hotels.Commands;
global using Accommodation.Application.UseCases.Hotels.Queries;
global using Accommodation.Application.UseCases.Rooms.Commands;
global using Accommodation.Application.UseCases.Rooms.Queries;
global using Accommodation.Application.UseCases.RoomTypes.Commands;
global using Accommodation.Application.UseCases.RoomTypes.Queries;
global using Accommodation.Application.UseCases.Staffs.Commands;
global using Accommodation.Application.UseCases.Staffs.Queries;
global using Accommodation.Domain.Entities.Bookings;
global using Accommodation.Domain.Entities.Guests;
global using Accommodation.Domain.Entities.Hotels;
global using Accommodation.Domain.Entities.Rooms;
global using Accommodation.Domain.Entities.Staffs;
global using Accommodation.Domain.Enums.Positions;
global using Accommodation.Domain.Enums.Status;
global using Accommodation.Domain.Exceptions.Bookings;
global using Accommodation.Domain.Exceptions.Guests;
global using Accommodation.Domain.Exceptions.Hotels;
global using Accommodation.Domain.Exceptions.Images;
global using Accommodation.Domain.Exceptions.Rooms;
global using Accommodation.Domain.Exceptions.Staffs;
global using MediatR;
global using Microsoft.AspNetCore.Http;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.DependencyInjection;
global using System.ComponentModel.DataAnnotations;
global using System.Reflection;
