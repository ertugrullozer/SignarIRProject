﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalIRWebUI.Dtos.AboutDtos;
using SignalIRWebUI.Dtos.CategoryDtos;
using System.Text;

namespace SignalIRWebUI.Controllers
{
	public class AboutController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public AboutController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:44338/api/About");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultAboutDtos>>(jsonData);
				return View(values);
			}
			return View();
		}

		[HttpGet]
		public IActionResult CreateAbout()
		{

			return View();
		}
		[HttpPost]
		public async Task<IActionResult> CreateAbout(CreateAboutDto createAboutDto)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createAboutDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PostAsync("https://localhost:44338/api/About", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}

			return View();

		}

		public async Task<IActionResult> DeleteAbout(int id)
		{

			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"https://localhost:44338/api/About/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}
		[HttpGet]
		public async Task<IActionResult> UpdateAbout(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"https://localhost:44338/api/About/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateAboutDtos>(jsonData);
				return View(values);
			}

			return View();

		}
		[HttpPost]
		public async Task<IActionResult> UpdateAbout(UpdateAboutDtos updateAboutDtos)
		{
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(updateAboutDtos);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("https://localhost:44338/api/About/", stringContent);
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");

			}
			return View();

		}
	}
    }
