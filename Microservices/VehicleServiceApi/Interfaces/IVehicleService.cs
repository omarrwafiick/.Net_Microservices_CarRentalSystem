﻿using VehicleServiceApi.Models;

namespace VehicleServiceApi.Interfaces
{
    public interface IVehicleService
    {
        Task<IEnumerable<Vehicle>> GetAllVehiclesAsync();
        Task<Vehicle> GetVehicleByIdAsync(Guid id);
        Task<bool> CreateVehicleAsync(Vehicle domain);
        Task<bool> UpdateVehicleAsync(Vehicle domain);
        Task<bool> DeleteVehicleAsync(Guid id);
        Task<IEnumerable<Vehicle>> GetAvailableVehiclesAsync();
    }
}
