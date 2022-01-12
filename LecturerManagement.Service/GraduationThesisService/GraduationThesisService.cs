﻿using AutoMapper;
using LecturerManagement.Core.Contracts;
using LecturerManagement.Core.Models;
using LecturerManagement.Core.Models.Entities;
using LecturerManagement.DTOS.GraduationThesis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LecturerManagement.Services.GraduationThesisService
{
    public class GraduationThesisService : IGraduationThesisService
    {

        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public GraduationThesisService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<ServiceResponse<AddGraduationThesisDto>> Create(AddGraduationThesisDto createGraduationThesis)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<GraduationThesis>> Delete(GraduationThesis deleteGraduationThesis)
        {
            throw new NotImplementedException();
        }

        public async Task<GetGraduationThesisDto> Find(Expression<Func<GraduationThesis, bool>> expression = null, List<string> includes = null)
         => _mapper.Map<GetGraduationThesisDto>(await _unitOfWork.GraduationThesises.FindByConditionAsync(expression, includes));

        public async Task<ICollection<GetGraduationThesisDto>> FindAll(Expression<Func<GraduationThesis, bool>> expression = null, Func<IQueryable<GraduationThesis>, IOrderedQueryable<GraduationThesis>> orderBy = null, List<string> includes = null)
        => _mapper.Map<ICollection<GetGraduationThesisDto>>(await _unitOfWork.GraduationThesises.FindAllAsync(expression, orderBy, includes));


        public async Task<bool> IsExisted(Expression<Func<GraduationThesis, bool>> expression = null)
        {
            var isExist = await _unitOfWork.GraduationThesises.FindByConditionAsync(expression);
            if (isExist == null)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> SaveChange()
            => await _unitOfWork.GraduationThesises.Save();

        public async Task<ServiceResponse<UpdateGraduationThesisDto>> Update(UpdateGraduationThesisDto updateGraduationThesis)
        {
            try
            {
                var graduationThesisFromDB = await Find(x => x.Id == 1);
                if (graduationThesisFromDB != null)
                {
                    var task = _mapper.Map<GraduationThesis>(updateGraduationThesis);
                    _unitOfWork.GraduationThesises.Update(task);
                    if (!await SaveChange())
                    {
                        return new ServiceResponse<UpdateGraduationThesisDto> { Success = false, Message = "Error when update Graduation Thesis" };
                    }
                    return new ServiceResponse<UpdateGraduationThesisDto> { Success = true, Message = "Update Graduation Thesis Success" };
                }
                else
                {
                    return new ServiceResponse<UpdateGraduationThesisDto> { Success = false, Message = "Not Found Graduation Thesis" };
                }
            }
            catch (Exception ex)
            {
                return new ServiceResponse<UpdateGraduationThesisDto> { Success = false, Message = ex.Message };
            }
        }
    }
}