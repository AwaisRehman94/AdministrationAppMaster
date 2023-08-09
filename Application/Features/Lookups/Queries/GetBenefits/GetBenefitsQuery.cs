
using Microsoft.EntityFrameworkCore;

using Inquiry.Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using GlobalCommon.Models;
using System.Collections.Generic;

namespace Inquiry.Application.Features.Lookups.Queries.GetBenefits
{
    public class GetBenefitsRequest : IRequest<Result<List<GetBenefitResponse>>>
    {
        public string Language { get; set; }
    }

    public class GetBenefitsRequestHandler : IRequestHandler<GetBenefitsRequest, Result<List<GetBenefitResponse>>>
    {        
        //private readonly IApplicationDbContext _context;
        private readonly IAutoleasingBenefitRepository _repository;
        private readonly IMapper _mapper;
        public GetBenefitsRequestHandler(IAutoleasingBenefitRepository repository, IMapper mapper)
        {
           
            _repository= repository;
            _mapper = mapper;
        }

        public async Task<Result<List<GetBenefitResponse>>> Handle(GetBenefitsRequest request, CancellationToken cancellationToken)
        {
            Result<List<GetBenefitResponse>> result = new Result<List<GetBenefitResponse>>();
            result.ErrorDescription = "Success";
            result.ErrorCode = 1;

            if (request.Language == "en")
            {
               
               var _result = await _repository.GetBenefits();
                if (_result != null)
                {
                    var _collection = new List<GetBenefitResponse>();
                    foreach (var item in _result)
                    {
                        _collection.Add(new GetBenefitResponse()
                        {
                            Id = Convert.ToInt32(item.Code),
                            Name = item.EnglishDescription,
                            ReadOnly = (item.Code == 1 || item.Code == 10) ? true : false
                        });
                    }
                    result.Data = _collection;
                }
            }
            else if (request.Language == "ar")
            {
                var _result = await _repository.GetBenefits();
                if (_result != null)
                {
                    var _collection = new List<GetBenefitResponse>();
                    foreach (var item in _result)
                    {
                        _collection.Add(new GetBenefitResponse()
                        {
                            Id = Convert.ToInt32(item.Code),
                            Name = item.ArabicDescription,
                            ReadOnly = (item.Code == 1 || item.Code == 10) ? true : false
                        });
                    }
                    result.Data = _collection;
                }
            }

            return result;

        }
    }
}
