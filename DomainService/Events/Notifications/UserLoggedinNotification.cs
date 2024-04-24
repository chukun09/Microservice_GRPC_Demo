﻿using DomainService.AuthenticationService.Input;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Events.Notifications
{
    public record UserLoggedinNotification(SignInResult signInResult) : INotification;
}
