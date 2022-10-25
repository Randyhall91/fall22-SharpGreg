<template>
  <div class="card">
    <div class="card-header">
      {{job.jobTitle}}
      <h5>{{job.company}}</h5>
    </div>
    <div class="card-body d-flex justify-content-between align-items-center">
      <div class="align-items-center d-flex gap-2">
        <div class="me-auto">
          <h5>{{job.hours}}hr/week - ${{job.rate}}/hr</h5>
        </div>
      </div>

      <div class="align-items-center d-flex gap-2">
        <img :src="seller.picture" :alt="seller.name" :title="seller.name" height="30" class="rounded">
        <i class="mdi mdi-delete-forever fs-4 selectable rounded" @click.stop="$emit('deleteClassified')"
          v-if="account.id == seller.id"></i>
      </div>
    </div>
    <div class="card-footer">
      <p>{{job.description}}</p>
    </div>
  </div>
</template>


<script>
import { computed } from '@vue/reactivity';
import { AppState } from '../AppState.js';
import { Job } from '../models/Job.js';
import { SellerProfile } from '../models/SellerProfile.js';

export default {
  props: {
    job: { type: Job, required: true },
    seller: { type: SellerProfile, required: true }
  },
  setup(props, { emit }) {

    return {
      account: computed(() => AppState.account),
      deleteClassified() {
        emit('deleteClassified')
      }
    }
  }
}
</script>


<style lang="scss" scoped>

</style>