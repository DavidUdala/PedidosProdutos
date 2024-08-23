﻿using AutoMapper;
using PedidosProdutos.Dominio.Dtos.Requests;
using PedidosProdutos.Dominio.Dtos.Responses;
using PedidosProdutos.Dominio.Entidades;

namespace PedidosProdutos.Dominio.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ItemPedidoRequest, ItensPedido>();

            CreateMap<PedidoRequest, Pedido>()
                .ForMember(dest => dest.ItensPedidos, opt => opt
                    .MapFrom(src => src.ItensPedidos))
                .ReverseMap();

            CreateMap<Pedido, PedidoResponse>()
                .ForMember(dest => dest.ItensPedido, opt => opt
                    .MapFrom(src => src.ItensPedidos))
                .ForMember(dest => dest.ValorTotal, opt => opt
                    .MapFrom(src => src.ItensPedidos!
                        .Sum(item => item.Quantidade * item.Produto!.Valor)));

            CreateMap<Produto, PedidoResponse>()
                .ForMember(dest => dest.ItensPedido, opt => opt
                    .MapFrom(src => src.ItensPedidos));

            CreateMap<ItensPedido, ItemPedidoResponse>()
                .ForMember(dest => dest.ValorUnitario, opt => opt
                    .MapFrom(src => src.Produto!.Valor))
                .ForMember(dest => dest.NomeProduto, opt => opt
                    .MapFrom(src => src.Produto!.NomeProduto));

            CreateMap<Produto, ProdutoResponse>()
                .ReverseMap();
        }
    }
}
