using AutoMapper;
using Azure.Core;
using BAL.IServices;
using MODEL.DTOs.TaskDTOs;
using MODEL.Entities;
using REPOSITORY.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class NoteService : INoteService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public NoteService(IUnitOfWork unitOfWork, IMapper mapper) 
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task CreateNote(CreateNoteDTO request)
        {
            if (request == null)
            {
                throw new ArgumentNullException();
            }

            var note = _mapper.Map<Note>(request);

            await _unitOfWork.Note.Create(note);
            await _unitOfWork.SaveAsyncChanges();
        }

        public async Task DeleteNote(Note request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("No request");
            }

            var note = _unitOfWork.Note.GetById(request.Id);

            if(note == null)
            {
                throw new ArgumentNullException("Not Found!");
            }

            _unitOfWork.Note.Delete(request);
            await _unitOfWork.SaveAsyncChanges();
        }

        public async Task<IEnumerable<Note>> GetAllNotes()
        {
            return await _unitOfWork.Note.GetAll();
        }

        public async Task UpdateNote(Note request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("No request");
            }

            var note = await _unitOfWork.Note.GetById(request.Id);
            if (note == null)
            {
                throw new ArgumentNullException("Not Found!");
            }

            _unitOfWork.Note.Update(request);
            await _unitOfWork.SaveAsyncChanges();
        }
    }
}
