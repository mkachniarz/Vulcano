using MediatR;
using Volcano.Core.Requests;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblyContaining<GetTireRequest>());

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapGet("/tires/{id}", (int id, IMediator _mediator) => _mediator.Send(new GetTireRequest(id)));

app.Run();