using Case.Application.Abstraction;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case.Persistence
{
    public static class ServiceRegistration
    {
        public static void addPersistenceRegistration(this IServiceCollection services) 
        {
			// static sınıf olmasının sebebi içerisinde extension function tanımlıyoruz
            services.AddScoped<IOrderService, OrderService>();
        }
		// Bu methodu Presentation da program.cs içerisinde kullandık.
    }
}
