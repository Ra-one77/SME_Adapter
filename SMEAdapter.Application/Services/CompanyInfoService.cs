using SMEAdapter.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMEAdapter.Application.Services
{
    public class CompanyInfoService 
    {
        public CompanyDto?   CurrentCompany { get; set; }
        // Event to notify subscribers
        public event Func<Task>? OnChange;

        // Method to update the company and notify subscribers
        public void SetCompany(CompanyDto company)
        {
            CurrentCompany = company;
            NotifyStateChanged();
        }

        private async void NotifyStateChanged()
        {
            if (OnChange != null)
            {
                foreach (var handler in OnChange.GetInvocationList())
                {
                    await ((Func<Task>)handler)();
                }
            }
        }
    }
}
