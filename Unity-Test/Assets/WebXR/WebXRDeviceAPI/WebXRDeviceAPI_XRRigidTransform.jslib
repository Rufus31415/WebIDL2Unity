
mergeInto(LibraryManager.library, {

    XRRigidTransform_2 : function(position, orientation) {
        return _WebIDL2Unity.addReference(new XRRigidTransform(_WebIDL2Unity.references[position], _WebIDL2Unity.references[orientation]));
    }

});
