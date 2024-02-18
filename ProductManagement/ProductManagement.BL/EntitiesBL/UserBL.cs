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
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.BL.EntitiesBL
{
    public class UserBL : IBaseBL<CreateUserDto, UpdateUserDto>
    {
        // Fields for mapping and DAO.
        private readonly UserDAO _userDAO;

        private readonly IMapper _mapper;

        // Initialize constructor
        public UserBL()
        {
            _userDAO = new UserDAO();
            _mapper = AutoMapperConfig.Inicialize();
        }

        /// <summary>
        /// Business Intelligence validation before creating a user.
        /// </summary>
        /// <param name="createDto"></param>
        /// <returns></returns>
        public string ValidateBeforeCreate(CreateUserDto createDto)
        {
            // Definition of variables.
            var errorMessage = string.Empty;

            // Implementation of validations.
            var validator = new CreateUserValidator();

            var validationResult = validator.Validate(createDto);

            // Validation DTO.
            if (!validationResult.IsValid)
            {
                errorMessage = validationResult.ToString(" \n ");
                return errorMessage;
            }
            // Valid unique username.
            if (_userDAO.CheckWithCondition(x => x.UserName.ToLower() == createDto.UserName.ToLower()))
            {
                errorMessage = $"El nombre de usuario: {createDto.UserName} ya existe.";
                return errorMessage;
            }

            // Valid unique e-mail.
            if (_userDAO.CheckWithCondition(x => x.Email.ToLower() == createDto.Email.ToLower()))
            {
                errorMessage = $"El E-mail: {createDto.Email} ya existe.";
                return errorMessage;
            }

            return errorMessage;
        }

        /// <summary>
        /// Create user using validations.
        /// </summary>
        /// <param name="createDto"></param>
        /// <returns></returns>
        public OperationResultDto Create(CreateUserDto createDto)
        {
            // Definition of variables.
            var result = new OperationResultDto();
            var affectedRows = 0;
            var errorMessage = ValidateBeforeCreate(createDto);

            // Validate DTO
            if (string.IsNullOrEmpty(errorMessage))
            {
                // Map DTO to model
                var userModel = _mapper.Map<User>(createDto);
                userModel.Password = Security.Encrypt(userModel.Password);
                affectedRows = _userDAO.Create(userModel);
                var readUser = _mapper.Map<ReadUserDto>(userModel);
                
                result.Message = affectedRows > 0 ? "Creado con Exito." : "No se afectaron registros.";
                result.Success = affectedRows > 0;
                result.Result = readUser;
            }
            else
            {
                result.Message = errorMessage;
                result.Success = false;  
            }

            return result;
        }

        /// <summary>
        /// Validation before update user.
        /// </summary>
        /// <param name="updateDto"></param>
        /// <returns></returns>
        public string ValidateBeforeUpdate(UpdateUserDto updateDto)
        {
            // Definition of variables.
            var errorMessage = string.Empty;

            // Implementation of validations
            var validator = new UpdateUserValidator();

            var validationResult = validator.Validate(updateDto);

            // Validation DTO
            if (!validationResult.IsValid)
            {
                errorMessage = validationResult.ToString("\n");
                return errorMessage;
            }

            return errorMessage;
        }

        /// <summary>
        /// Update user.
        /// </summary>
        /// <param name="updateDto"></param>
        /// <returns></returns>
        public OperationResultDto Update(UpdateUserDto updateDto)
        {
            // Definition of variables.
            var result = new OperationResultDto();
            var affectedRows = 0;
            var errorMessage = ValidateBeforeUpdate(updateDto);

            // Validate DTO
            if (string.IsNullOrEmpty(errorMessage))
            {
                // Map DTO to model

                var userModel = _userDAO.FindById(updateDto.Id);
                _mapper.Map(updateDto, userModel);
                affectedRows = _userDAO.Update(userModel);

                var userDto = _mapper.Map<ReadUserDto>(userModel);

                result.Message = affectedRows > 0 ? "Actualizado con Exito." : "No se afectaron registros.";
                result.Success = affectedRows > 0;
                result.Result = userDto;
            }
            else
            {
                result.Message = errorMessage;
                result.Success = false;
            }

            return result;
        }


        /// <summary>
        /// Validation before delete user.
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public string ValidateBeforeDelete(int entityId)
        {
            // Definition of variables.
            var errorMessage = string.Empty;

            // Validate that the record exists 
            if (!_userDAO.CheckWithCondition(x => x.Id == entityId))
            {
                errorMessage = "El Usuario no existe.";
                return errorMessage;
            }
            if (_userDAO.CheckWithCondition(x => x.Products.Any(y => y.CreatedUserId == x.Id), includeProperties: nameof(User.Products)))
            {
                errorMessage = "El Usuario esta presente en los registros de Productos.";
                return errorMessage;
            }
            if (_userDAO.CheckWithCondition(x => x.Options.Any(y => y.CreatedUserId == x.Id), includeProperties: nameof(User.Options)))
            {
                errorMessage = "El Usuario esta presente en los registros de Opciones.";
                return errorMessage;
            }
            if (_userDAO.CheckWithCondition(x => x.Suppliers.Any(y => y.CreatedUserId == x.Id), includeProperties: nameof(User.Suppliers)))
            {
                errorMessage = "El Usuario esta presente en los registros de Proveedores.";
                return errorMessage;
            }

            return errorMessage;
        }


        /// <summary>
        /// Delete user.
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public OperationResultDto Delete(int entityId)
        {
            // Definition of variables.
            var result = new OperationResultDto();
            var affectedRows = 0;
            var errorMessage = ValidateBeforeDelete(entityId);

            // Validate
            if (string.IsNullOrEmpty(errorMessage))
            {
                // Get record and delete.
                var userModel = _userDAO.FindById(entityId);
                affectedRows = _userDAO.Delete(userModel);

                result.Message = affectedRows > 0 ? "Eliminado con Exito." : "No se afectaron registros.";
                result.Success = affectedRows > 0;
                result.Result = null;
            }
            else
            {
                result.Message = errorMessage;
                result.Success = false;
            }

            return result;
        }

        public OperationResultDto FindById(int entityId)
        {
            // Definition of variables.
            var result = new OperationResultDto();

            // Find user by Id.
            var userModel = _userDAO.FindById(entityId);
            var userDto = _mapper.Map<ReadUserDto>(userModel);

            // Validate if the record exists
            if (userModel == null)
            {
                result.Message = "No se encontraron registros.";
                result.Success = false;
                result.Result = null;
            }
            else
            {
                result.Message = "Usuario encontrado.";
                result.Success = true;
                result.Result = userDto;
            }

            return result;
        }

        public OperationResultDto ValidateLogin(string user, string pass)
        {
            // Definition of variables.
            var result = new OperationResultDto();
            // Find user by Id.
            var userModel = _userDAO.GetSingleWithFilter(x => x.UserName == user);

            // Validate if the record exists
            if (userModel == null)
            {
                result.Message = "No se encontro el registro.";
                result.Success = false;
                result.Result = null;

                return result;
            }

            if ( userModel.Password != Security.Encrypt(pass))
            {
                result.Message = "Contraseña incorrecta.";
                result.Success = false;
                result.Result = null;

                return result;
            }
            else
            {
                result.Message = "Credenciales correctas.";
                result.Success = true;
                result.Result = userModel;
            }

            return result;
        }
    }
}
