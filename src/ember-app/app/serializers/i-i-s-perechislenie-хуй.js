import { Serializer as ХуйSerializer } from
  '../mixins/regenerated/serializers/i-i-s-perechislenie-хуй';
import __ApplicationSerializer from './application';

export default __ApplicationSerializer.extend(ХуйSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
