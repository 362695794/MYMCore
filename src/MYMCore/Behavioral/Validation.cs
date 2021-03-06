﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MYMCore.Behavioral {
    public class Validation {

        public static bool IsValidate<T>(T t, out List<ValidationResult> result) {
            var content = new ValidationContext(t);
            result = new List<ValidationResult>();
            return Validator.TryValidateObject(t, content, result);
        }

        public static bool IsValidateProperty<T>(T t, string field, object validateValue, out List<ValidationResult> result) {
            var content = new ValidationContext(t);
            content.MemberName = field;
            result = new List<ValidationResult>();
            return Validator.TryValidateProperty(validateValue, content, result);
        }
    }
}
