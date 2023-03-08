using ChallengeAlternativo.Core.Repository.Interfaces;
using ChallengeAlternativo.Core.Services.Interfaces;
using ChallengeAlternativo.DTOs;
using ChallengeAlternativo.Models;
using System;

public class GeographicIconsServices : IGeographicIconsServices
{
	private readonly IGeographicIconsRepository _repository;	
	public GeographicIconsServices(IGeographicIconsRepository repository)
	{
		_repository = repository;
	}

	public async Task<GeographicIcons> CreateGeographicIcons(CreateGeographicIconsDTO createGeographicIconsDTO)
	{
		return await _repository.CreateGeographicIcons(new GeographicIcons(createGeographicIconsDTO));
	}

	public async Task DeleteGeographicIcons(int id)
	{
		await _repository.DeleteGeographicsIcons(id);
	}

	public async Task<List<GeographicIcons>> GetGeographicIcons()
	{
		return await _repository.GetGeographicIcons();
	}

	public async Task UpdateGeographicIcons(GeographicIcons geographicIcons)
	{
		await _repository.UpdateGeographicsIcons(geographicIcons);
	}
}
