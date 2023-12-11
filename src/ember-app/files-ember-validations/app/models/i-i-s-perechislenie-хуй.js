import {
  defineNamespace,
  defineProjections,
  Model as ХуйMixin
} from '../mixins/regenerated/models/i-i-s-perechislenie-хуй';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(ХуйMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
