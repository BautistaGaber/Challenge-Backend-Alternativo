using ChallengeAlternativo.Core.Repository.Interfaces;
using ChallengeAlternativo.Core.Services.Interfaces;
using ChallengeAlternativo.DTOs;
using ChallengeAlternativo.Helper;
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
		return await _repository.CreateGeographicIcons(ApiHelper.CreateGeographicIconsDtoToEntity(createGeographicIconsDTO));
	}

	public async Task DeleteGeographicIcons(int id)
	{
		await _repository.DeleteGeographicsIcons(id);
	}

	public async Task<List<GeographicIcons>> GetGeographicIcons()
	{
		return await _repository.GetGeographicIcons();
	}

	public async Task<GeographicIcons> UpdateGeographicIconsById(int id)
	{
		return await _repository.GetGeographicIconsById(id);
	}

	public async Task UpdateGeographicIcons(UpdateGeographicIconsDTO updateGeographicIconsDTO, int id)
	{
		GeographicIcons GeographicIcons = await _repository.GetGeographicIconsById(id);
		if(GeographicIcons == null)
			return;
		await _repository.UpdateGeographicsIcons(ApiHelper.UpdateGeographicIconsDtoToEntity(updateGeographicIconsDTO, GeographicIcons));
	}
}
