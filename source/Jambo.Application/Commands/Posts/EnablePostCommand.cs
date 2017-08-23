﻿using MediatR;
using System.Runtime.Serialization;
using Jambo.Application.Commands;
using System;

namespace Jambo.Application.Commands.Posts
{
    [DataContract]
    public class EnablePostCommand : IRequest
    {
        [DataMember]
        public Guid Id { get; private set; }

        public EnablePostCommand()
        {

        }

        public EnablePostCommand(Guid id) : this()
        {
            Id = id;
        }
    }
}