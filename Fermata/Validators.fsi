namespace Fermata
    
    module Validators =
        
        val validateNotNullOrEmpty: input: string -> Result<string,Fermata.Errors.Errors>

        val validateNotEmptyString: input: string -> Result<string,Fermata.Errors.Errors>
        
        val validateFormat: format: string -> input: string-> Result<string,Fermata.Errors.Errors>
        
        val validateRange: min: 'T -> max: 'T -> input: 'T -> Result<'T,Fermata.Errors.Errors> when 'T: comparison

