using MediatR;
using Volcano.Core.Requests;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(cfn => cfn.RegisterServicesFromAssemblyContaining<GetTyreRequest>());

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapGet("/tires/{id}", (int id, IMediator _mediator) => _mediator.Send(new GetTyreRequest(id)));

app.Run();