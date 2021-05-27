
mergeInto(LibraryManager.library, {

    XRFrame_GetJointPose : function(id, joint, baseSpace) {
        var value = _WebIDL2Unity.references[id].getJointPose(_WebIDL2Unity.references[joint], _WebIDL2Unity.references[baseSpace]);
        return _WebIDL2Unity.addReference(value);
    }
,

    XRFrame_FillJointRadii : function(id, jointSpaces, radii) {
        var value = _WebIDL2Unity.references[id].fillJointRadii(_WebIDL2Unity.references[jointSpaces], _WebIDL2Unity.references[radii]);
        return value;
    }
,

    XRFrame_FillPoses : function(id, spaces, baseSpace, transforms) {
        var value = _WebIDL2Unity.references[id].fillPoses(_WebIDL2Unity.references[spaces], _WebIDL2Unity.references[baseSpace], _WebIDL2Unity.references[transforms]);
        return value;
    }

});
