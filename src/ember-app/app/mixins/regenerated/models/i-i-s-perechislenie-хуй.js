import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  перечисление: DS.attr('i-i-s-perechislenie-хуй1')
});

export let ValidationRules = {
  перечисление: {
    descriptionKey: 'models.i-i-s-perechislenie-хуй.validations.перечисление.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ХуйE', 'i-i-s-perechislenie-хуй', {
    перечисление: attr('Перечисление', { index: 0 })
  });

  modelClass.defineProjection('ХуйL', 'i-i-s-perechislenie-хуй', {
    перечисление: attr('Перечисление', { index: 0 })
  });
};
