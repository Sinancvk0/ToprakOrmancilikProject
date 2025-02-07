﻿using Bussiness.Content;
using Bussiness.Services;
using Data.Abstract;
using Data.EntityFramework;
using Helper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Container
{
    public class ExtensionsDb
    {
        public static void ContainerDependencies(IServiceCollection services)
        {
            services.AddScoped<IAboutService,AboutManager>();   
            services.AddScoped<IAboutDal,EfAboutDal>(); 

            services.AddScoped<IContactService,ContactManager>();   
            services.AddScoped<IContactDal,EfContactDal>(); 

            services.AddScoped<IGalleryService,GalleryManager>();
            services.AddScoped<IGalleryDal,EfGalleryDal>();   

            services.AddScoped<IProductService,ProductManager>();   
            services.AddScoped<IProductDal,EfProductDal>(); 

            services.AddScoped<ISliderService,SliderManager>(); 
            services.AddScoped<ISliderDal,EfSliderDal>();   
            
            services.AddScoped<IQuestionService,QuestionManager>(); 
            services.AddScoped<IQuestion,EfQuestion>();

            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IBlogDal, EfBlog>();
            
             services.AddScoped<IMessageService,MessageManager>();
            services.AddScoped<IMessageDal, EfMessage>();

            services.AddScoped<IDocumentService, DocumentManager>();    
            services.AddScoped<IDocumentDal,EfDocument>();  

            services.AddSingleton<FileUpload>();

        }
    }
}
