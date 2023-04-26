﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Http.Headers;
using WEB.Models;
using Lesson12.API.DataTransferObjects;

namespace WEB.Pages
{
    public class IndexModel : PageModel
    {
        private HttpClient _client;

        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public CalcModel CalcModel { get; set; }

        public List<SelectListItem> OperationList { get; } = new List<SelectListItem> {
            new SelectListItem { Value = "plus", Text = "+" },
            new SelectListItem { Value = "minus", Text = "-" },
            new SelectListItem { Value = "krat", Text = "*" },
            new SelectListItem { Value = "deleno", Text = "/" }
            };

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7189/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new
            MediaTypeWithQualityHeaderValue("application/json"));
            CalcModel = new CalcModel();
        }
        public void OnGet()
        {
        }
        public async Task OnPostCalculate()
        {
            CalcDTO calcDTO = new CalcDTO();
            calcDTO.Operand1 = CalcModel.Operand1;
            calcDTO.Operand2 = CalcModel.Operand2;
            calcDTO.Operation = CalcModel.Operation;
            HttpResponseMessage response = await
            _client.PostAsJsonAsync($"api/Calculator", calcDTO);
            response.EnsureSuccessStatusCode();
            ViewData["ResultValue"] = await response.Content.ReadAsStringAsync();
        }

    }
}