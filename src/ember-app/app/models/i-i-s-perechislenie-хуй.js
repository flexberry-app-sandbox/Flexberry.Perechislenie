import { buildValidations } from 'ember-cp-validations';
import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

import {
  defineProjections,
  ValidationRules,
  Model as ХуйMixin
} from '../mixins/regenerated/models/i-i-s-perechislenie-хуй';

const Validations = buildValidations(ValidationRules, {
  dependentKeys: ['model.i18n.locale'],
});

let Model = EmberFlexberryDataModel.extend(ХуйMixin, Validations, {
});

defineProjections(Model);

export default Model;
