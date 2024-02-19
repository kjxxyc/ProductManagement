using AutoMapper;
using ProductManagement.BL.DTOs;
using ProductManagement.BL.InterfacesBL;
using ProductManagement.BL.Utilities;
using ProductManagement.BL.Validators;
using ProductManagement.DAL.EntitiesDAO;
using ProductManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.BL.EntitiesBL
{
    public class OptionBL : IBaseBL<CreateOrUpdateOptionDto, UpdateOptionDto>
    {
        // Fields for mapping and DAO
        private readonly OptionDAO _optionDAO;

        private readonly IMapper _mapper;

        // Initialize constructor
        public OptionBL()
        {
            _optionDAO = new OptionDAO();
            _mapper = AutoMapperConfig.Inicialize();
        }


        /// <summary>
        /// Create Option using validations.
        /// </summary>
        /// <param name="createDto"></param>
        /// <returns></returns>
        public OperationResultDto Create(CreateOrUpdateOptionDto createDto)
        {
            // Definition of variables.
            var result = new OperationResultDto();
            var affectedRows = 0;
            var errorMessage = ValidateBeforeCreate(createDto);

            // Validate DTO
            if (string.IsNullOrEmpty(errorMessage))
            {
                // Map DTO to model
                var optionModel = _mapper.Map<Option>(createDto);
                affectedRows = _optionDAO.Create(optionModel);

                result.Message = affectedRows > 0 ? "Creado con Exito." : "No se afectaron registros.";
                result.Success = affectedRows > 0;
                result.Result = optionModel;
            }
            else
            {
                result.Message = errorMessage;
                result.Success = false;
            }

            return result;
        }

        public OperationResultDto Delete(int entityId)
        {
            throw new NotImplementedException();
        }

        public OperationResultDto FindById(int entityId)
        {

            // Definition of variables.
            var result = new OperationResultDto();

            // Find user by Id.
            var optionModel = _optionDAO.FindById(entityId);
            var optionDto = _mapper.Map<ReadOptionDto>(optionModel);

            // Validate if the record exists
            if (optionModel == null)
            {
                result.Message = "No se encontraron registros.";
                result.Success = false;
                result.Result = null;
            }
            else
            {
                result.Message = "Opción encontrada.";
                result.Success = true;
                result.Result = optionDto;
            }

            return result;
        }

        public OperationResultDto Update(UpdateOptionDto updateDto)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Business Intelligence validation before creating a Option.
        /// </summary>
        /// <param name="createDto"></param>
        /// <returns></returns>
        public string ValidateBeforeCreate(CreateOrUpdateOptionDto createDto)
        {
            // Definition of variables.
            var errorMessage = string.Empty;

            // Implementation of validations.
            var validator = new CreateOptionValidator();

            var validationResult = validator.Validate(createDto);

            // Validation DTO.
            if (!validationResult.IsValid)
            {
                errorMessage = validationResult.ToString(" \n ");
                return errorMessage;
            }

            return errorMessage;
        }

        public string ValidateBeforeDelete(int entityId)
        {
            throw new NotImplementedException();
        }

        public string ValidateBeforeUpdate(UpdateOptionDto updateDto)
        {
            throw new NotImplementedException();
        }
    }
}
