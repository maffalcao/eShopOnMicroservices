using AutoMapper;
using Discount.Grpc.Entities;
using Discount.Grpc.Protos;

namespace Discount.Grpc.Mapper;

public class DiscountProfille: Profile
{
    public DiscountProfille()
    {
        CreateMap<Coupon, CouponModel>();        
    }
}