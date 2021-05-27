
mergeInto(LibraryManager.library, {

    XRSession_RequestLightProbe : function(id, options, callback) {
        var value = _WebIDL2Unity.references[id].requestLightProbe(_WebIDL2Unity.references[options]);
        
        var promise =  _WebIDL2Unity.addReference(value);

        value.then(function(a0){
            Module["dynCall_vii"](callback, promise, _WebIDL2Unity.addReference(a0));
        });

        return promise;
    }

});
